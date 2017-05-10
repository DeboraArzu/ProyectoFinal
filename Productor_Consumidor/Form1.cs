using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Productor_Consumidor
{
    public partial class fmWorker : Form
    {
        #region variables
        int numeroC, numeroP, idC, idP;
        string destino, origen = "";
        bool insertar = true;
        Queue<Comandos> instrucciones = new Queue<Comandos>();
        Queue<string> queue = new Queue<string>();
        Object lockObj = new object();
        List<Consumer> consumidores = new List<Consumer>();
        int cantidad = 0;
        #endregion

        RoundRobin robin;
        Worker WC;
        Worker WP;
        public fmWorker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            Agregar.Enabled = false;
            btremove.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizartabla();
        }

        void actualizartabla()
        {
            //se actualiza la tabla
            for (int i = 0; i < numeroC; i++)
            {
                dtconsumers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtconsumers.Rows[i].Cells[1].Value = WC.getEstadoConsumidor(i);
                dtconsumers.Rows[i].Cells[2].Value = WC.getRequestConsumidor(i) + "/" + WC.getRequestConsumidorTotal(i);

                dtproducers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtproducers.Rows[i].Cells[1].Value = WP.getEstadoProductor(i);
                dtproducers.Rows[i].Cells[2].Value = WP.getRequestProductores(i) + "/" + WP.getRequestProductorTotal(i);
            }
        }

        void Disponibilidad() //maneja la disponibilidad de los threads
        {
            //para este punto ya se conoce el id de consumidor y productor
            numeroC--; numeroP--; //se resta uno para decir que un thread de cada uno ya esta ocupado
            if (numeroC > 0 && numeroP > 0) //aun hay disponibles
            {
                if (insertar)
                {
                    WP.IniciarProcesosProd(idP);
                    WC.IniciarProcesosConsI(idC);
                    WC.setLibreConsumidor(idC, false);
                    WP.setLibreProductor(idP, false);
                    actualizartabla();
                    numeroC++;
                    numeroP++;
                    robin.returntoQueue(idP, idC);
                    WC.setLibreConsumidor(idC, true);
                    WP.setLibreProductor(idP, true);
                }
                else //delete
                {
                    WP.IniciarProcesosProd(idP);
                    WC.IniciarProcesosConsD(idC);
                    actualizartabla();
                    numeroC++;
                    numeroP++;
                }

            }
            else
            {
                //entra en cola la intruccion
                Comandos cmd = new Comandos("", origen, destino);
                instrucciones.Enqueue(cmd);
                if (insertar)
                {
                    WC.agregarOrigenDestino(idC, origen, destino);
                    WP.IniciarProcesosProd(idP);
                    WC.IniciarProcesosConsI(idC);
                    WC.setLibreConsumidor(idC, false);
                    WP.setLibreProductor(idP, false);
                    actualizartabla();
                    numeroC++;
                    numeroP++;
                    robin.returntoQueue(idP, idC);
                    WC.setLibreConsumidor(idC, true);
                    WP.setLibreProductor(idP, true);
                }
                else //delete
                {
                    WP.IniciarProcesosProd(idP);
                    WC.IniciarProcesosConsD(idC);
                    actualizartabla();
                    numeroC++;
                    numeroP++;
                }
            }
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            Agregar.Enabled = true;
            btremove.Enabled = true;
            numeroC = Convert.ToInt32(txtcons.Text);
            numeroP = Convert.ToInt32(txtprod.Text); //numero de productores y consumidores
            WC = new Worker(0, "Consumer", numeroC);
            WP = new Worker(1, "Producer", numeroP);
            robin = new RoundRobin(numeroP, numeroC);
            //agregar consumers
            dtconsumers.Rows.Add(numeroC);
            //agregar producers
            dtproducers.Rows.Add(numeroP);
            for (int i = 0; i < 3; i++)
            {
                WC.agregarConsumer(i, true, queue, lockObj);
                WP.agregarProducer(i, true, queue);

                dtconsumers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtconsumers.Rows[i].Cells[1].Value = "Libre";
                dtconsumers.Rows[i].Cells[2].Value = "0/" + cantidad;

                dtproducers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtproducers.Rows[i].Cells[1].Value = "Libre";
                dtproducers.Rows[i].Cells[2].Value = "0/" + cantidad;
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                insertar = true;
                origen = Origen.Text;
                destino = Destino.Text;     //datos para sql
                cantidad = int.Parse(TxtCantidad.Text); //numero de veces que se ejecuta la instruccion
                                                        //set idC e idP   ID de consumidor y productor a emplear
                robin.RoundRobinexe();
                idC = robin.getIDc();
                idP = robin.getIDp(); //temporal emplear metodo round robin
                                      //agregar destino y origen
                WC.agregarOrigenDestino(idC, origen, destino);
                WP.sendCantidadProducers(cantidad, idP);
                WC.sendRequestConsumer(cantidad, idC);
                Disponibilidad();                       //inicia el codigo y verifica si hay threads disponibles
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los datos ingresados \n" + " verifique los datos", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btremove_Click(object sender, EventArgs e)
        {
            insertar = false;
            timer1.Start();
            origen = Origen.Text;
            destino = Destino.Text;     //datos para sql
            //set idC e idP   ID de consumidor y productor a emplear
            //agregar destino y origen
            cantidad = int.Parse(TxtCantidad.Text); //numero de veces que se ejecuta la instruccionKD
            WP.sendCantidadProducers(cantidad, idP);
            WC.sendRequestConsumer(cantidad, idC);
            WC.agregarOrigenDestino(idC, origen, destino);
            cantidad = int.Parse(TxtCantidad.Text); //numero de veces que se ejecuta la instruccion
            Disponibilidad();
        }
    }
}

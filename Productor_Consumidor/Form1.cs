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
        Object lockObj = new object();
        Queue<string> queue = new Queue<string>();
        int numeroC, numeroP, idC, idP;
        string destino, origen, scommand = "";
        bool insertar = true;
        Queue<Comandos> instrucciones = new Queue<Comandos>();
        List<Consumer> consumidores = new List<Consumer>();
        List<Producer> productores = new List<Producer>();
        int cantidad = 0;
        #endregion

        Worker WC;
        Worker WP;
        public fmWorker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
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
                dtconsumers.Rows[i].Cells[2].Value = WC.getRequestConsumidor(i) + "/" + cantidad;

                dtproducers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtproducers.Rows[i].Cells[1].Value = WP.getEstadoProductor(i);
                dtproducers.Rows[i].Cells[2].Value = WP.getRequestProductores(i) +"0/" + cantidad;
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
                    WC.IniciarProcesosCons(idC);
                    actualizartabla();
                    numeroC++;
                    numeroP++;
                }
                else //delete
                {

                }

            }
            else
            {
                //entra en cola la intruccion
                Comandos cmd = new Comandos("", origen, destino);
                instrucciones.Enqueue(cmd);
            }
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            numeroC = Convert.ToInt32(txtcons.Text);
            numeroP = Convert.ToInt32(txtprod.Text); //numero de productores y consumidores
            WC = new Worker(0, "Consumer", numeroC);
            WP = new Worker(1, "Producer", numeroP);
            //agregar consumers
            dtconsumers.Rows.Add(numeroC);
            //agregar producers
            dtproducers.Rows.Add(numeroP);
            for (int i = 0; i < 3; i++)
            {
                WC.agregarConsumer(i, true);
                WP.agregarProducer(i, true);

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
            timer1.Start();
            insertar = true;
            origen = Origen.Text;
            destino = Destino.Text;     //datos para sql
            //set idC e idP   ID de consumidor y productor a emplear
            //agregar destino y origen
            WC.agregarOrigenDestino(idC, origen, destino);
            cantidad = int.Parse(TxtCantidad.Text); //numero de veces que se ejecuta la instruccion
            Disponibilidad();                       //inicia el codigo y verifica si hay threads disponibles
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            insertar = false;
            timer1.Start();
            origen = Origen.Text;
            destino = Destino.Text;     //datos para sql
            //set idC e idP   ID de consumidor y productor a emplear
            //agregar destino y origen
            WC.agregarOrigenDestino(idC, origen, destino);
            cantidad = int.Parse(TxtCantidad.Text); //numero de veces que se ejecuta la instruccion
            Disponibilidad();
        }
    }
}

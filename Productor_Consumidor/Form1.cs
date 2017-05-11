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
        int numeroC, numeroP, idC, idP, tamañocola, cantidadworkers;
        int contador, totalinserts, totaldeletes, contador2 = 0;
        int contadoraux, contadorp = 0;
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

        private void btremove_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                insertar = false;
                timer1.Start();
                origen = Origen.Text;
                destino = Destino.Text;     //datos para sql

                timer1.Start();
                timer2.Start();
                robin = new RoundRobin(contador2, contador2);
                WC = new Worker(0, "Consumer", numeroC);
                WP = new Worker(1, "Producer", numeroP);
                contadoraux = tamañocola;
                contadorp = 0;
                for (int i = 0; i < contador2; i++)
                {
                    WP.agregarProducer(i, true, queue);
                    WC.agregarConsumer(i, true, queue, lockObj);
                    //comenzar a producir
                    manejo2();
                }
                contador2 = 0;
                porsilasdudas();
            }
            catch (Exception)
            {

            }

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            tabla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer2.Interval = 1500;
            Agregar.Enabled = false;
            btremove.Enabled = false;
        }

        private void Agregar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                insertar = true;
                origen = Origen.Text;
                destino = Destino.Text;     //datos para sql
                cantidad = int.Parse(TxtCantidad.Text); //numero de veces que se ejecuta la instruccion
                tamañocola = Convert.ToInt32(txtCola.Text);

                timer1.Start();
                timer2.Start();
                robin = new RoundRobin(contador, contador);
                WC = new Worker(0, "Consumer", numeroC);
                WP = new Worker(1, "Producer", numeroP);
                contadoraux = cantidad;
                contadorp = 0;
                for (int i = 0; i < contador; i++)
                {
                    WP.agregarProducer(i, true, queue);
                    WC.agregarConsumer(i, true, queue, lockObj);
                    //comenzar a producir
                    manejo();
                }
                contador = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los datos ingresados \n" + " verifique los datos", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizartabla();
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            Agregar.Enabled = true;
            btremove.Enabled = true;
            numeroC = Convert.ToInt32(txtcons.Text);
            numeroP = Convert.ToInt32(txtprod.Text); //numero de productores y consumidores
            cantidadworkers = Convert.ToInt32(txtworker.Text);
            dtconsumers.Rows.Add(numeroC);
            dtproducers.Rows.Add(numeroP);

            for (int i = 0; i < numeroP; i++)
            {
                dtproducers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtproducers.Rows[i].Cells[1].Value = "Libre";
                dtproducers.Rows[i].Cells[2].Value = "0/" + cantidad;
            }
            for (int i = 0; i < numeroC; i++)
            {
                dtconsumers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtconsumers.Rows[i].Cells[1].Value = "Libre";
                dtconsumers.Rows[i].Cells[2].Value = "0/" + cantidad;
            }

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                contador++; //en base a esto se crean productores y consumidores
            }
            catch (Exception)
            {

            }

        }

        private void btremove_Click(object sender, EventArgs e)
        {
            contador2++;

        }

        void actualizartabla()
        {
            //se actualiza la tabla
            /*si el numero de clics es menor o igual a la cantidad de workes entonces idc o idp 
            de lo contrario se debe de usar el i del for
             */
            try
            {
                for (int i = 0; i < WP.numerocolaP(); i++)
                {
                    dtproducers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                    dtproducers.Rows[i].Cells[1].Value = WP.getEstadoProductor(i);
                    dtproducers.Rows[i].Cells[2].Value = contadorp + "/" + cantidad;
                }
                for (int i = 0; i < WC.numerocolaC(); i++)
                {
                    dtconsumers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                    dtconsumers.Rows[i].Cells[1].Value = WC.getEstadoConsumidor(i);
                    dtconsumers.Rows[i].Cells[2].Value = contadoraux + "/" + cantidad;
                }
                if (contadorp < cantidad)
                {
                    contadorp++;

                }
                if (contadoraux > 0 && (contadorp == cantidad))
                {
                    contadoraux--;
                }
            }
            catch (Exception)
            {
                if (numeroC + numeroP < cantidadworkers)
                {
                    dtconsumers.Rows.Clear();
                    dtproducers.Rows.Clear();
                    tabla();
                }
                else
                {
                    //poner en cola las intrucciones
                }
                actualizartabla();
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
                WC.agregarOrigenDestino(numeroC + 4, origen, destino);
                WP.sendCantidadProducers(cantidad, numeroP + 4);
                WC.sendRequestConsumer(cantidad, numeroC + 4);
                WP.agregarProducer(numeroP + 4, true, queue);
                WC.agregarConsumer(numeroC + 4, true, queue, lockObj);
                WP.IniciarProcesosProd(numeroP + 4);
                WC.IniciarProcesosConsI(numeroC + 4);
                if (insertar)
                {
                    WP.IniciarProcesosProd(numeroP + 4);
                    WC.IniciarProcesosConsI(numeroC + 4);
                    WC.setLibreConsumidor(numeroC + 4, false);
                    WP.setLibreProductor(numeroP + 4, false);
                    actualizartabla();
                    numeroC++;
                    numeroP++;
                    robin.returntoQueue(idP, idC);
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

        void manejo()
        {
            robin.RoundRobinexe();
            idP = robin.getIDp();
            idC = robin.getIDc();
            WP.sendCantidadProducers(cantidad, idP);
            WC.sendRequestConsumer(cantidad, idC);
            WC.agregarOrigenDestino(idC, origen, destino);
            WP.IniciarProcesosProd(idP);
            robin.returntoQueue(idP, idC);
            WC.IniciarProcesosConsI(idC);
            cola();
        }

        void manejo2()
        {
            robin.RoundRobinexe();
            idP = robin.getIDp();
            idC = robin.getIDc();
            WP.sendCantidadProducers(cantidad, idP);
            WC.sendRequestConsumer(cantidad, idC);
            WC.agregarOrigenDestino(idC, origen, destino);
            WP.IniciarProcesosProd(idP);
            robin.returntoQueue(idP, idC);
            WC.IniciarProcesosConsD(idC);
        }

        void tabla()
        {
            try
            {
                dtproducers.Rows.Clear();
                dtconsumers.Rows.Clear();
                dtproducers.Rows.Add(WP.numerocolaP());
                dtconsumers.Rows.Add(WC.numerocolaC());
                for (int i = 0; i < WP.numerocolaP(); i++)
                {
                    //set estado consumidor
                    WP.setEstadoP(i, "Libre");
                }
                for (int i = 0; i < WC.numerocolaC(); i++)
                {
                    WC.setEstadoC(i, "libre");
                }
                actualizartabla();
            }
            catch (Exception)
            {

                throw;
            }

        }

        void cola()
        {
            while (cantidad > tamañocola)
            {
                //dividir la produccion
                //agregar producers y consumers
                try
                {
                    for (int i = 0; i < WP.numerocolaP(); i++)
                    {
                        dtproducers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                        dtproducers.Rows[i].Cells[1].Value = WP.getEstadoProductor(i);
                        dtproducers.Rows[i].Cells[2].Value = contadorp + "/" + tamañocola;
                    }
                    for (int i = 0; i < WC.numerocolaC(); i++)
                    {
                        dtconsumers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                        dtconsumers.Rows[i].Cells[1].Value = WC.getEstadoConsumidor(i);
                        dtconsumers.Rows[i].Cells[2].Value = contadoraux + "/" + tamañocola;
                        cantidad = cantidad - tamañocola;
                    }
                    if (contadorp < tamañocola)
                    {
                        contadorp++;
                    }
                    if (contadoraux > 0)
                    {
                        contadoraux--;
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        void porsilasdudas()
        {
            ComandosSQL sql = new ComandosSQL();
            sql.deleteData(origen, destino);
        }
    }
}

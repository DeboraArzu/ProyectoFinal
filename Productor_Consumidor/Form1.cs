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
        int numeroC, numeroP, disponibleC, disponibleP, idC, idP;
        string destino, origen, scommand = "";
        Queue<string> instrucciones = new Queue<string>();
        Queue<Consumer> consumidores = new Queue<Consumer>();
        Queue<Producer> productores = new Queue<Producer>();
        bool libre = true;
        int cantidad = 0;
        #endregion

        Producer P;
        Consumer C;
        Worker WC;
        Worker WP;

        public fmWorker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizartabla();
        }

        void actualizartabla()
        {
            //producers
            if (P.getRequest() >= 0)
            {
                libre = false;
                dtproducers.Rows[idP].Cells[0].Value = "Thread " + (idC).ToString();
                dtproducers.Rows[idP].Cells[1].Value = P.getEstado();
                dtproducers.Rows[idP].Cells[2].Value = P.getRequest().ToString() + "/10";
              //  P.setRequest(P.getRequest() - 1);
                //consumers
                dtconsumers.Rows[idC].Cells[0].Value = "Thread " + (idC).ToString();
                dtconsumers.Rows[idC].Cells[1].Value = C.getEstado();
                dtconsumers.Rows[idC].Cells[2].Value = C.getRequest().ToString() + "/10";
               // C.setRequest(C.getRequest() - 1);
            }
            if (C.getRequest() == 0)
            {
                //producer
                dtconsumers.Rows[idP].Cells[1].Value = "libre";
                P.setRequest(0);
                //consumer
                dtconsumers.Rows[idC].Cells[1].Value = "libre";
                C.setRequest(0);
                libre = true;
            }

            //se actualiza la tabla consumers
            //if (libre)
            //{
            //    if (C.getRequest() >= 0)
            //    {
            //        dtconsumers.Rows[idC].Cells[0].Value = "Thread " + (idC).ToString();
            //        dtconsumers.Rows[idC].Cells[1].Value = C.getEstado();
            //        dtconsumers.Rows[idC].Cells[2].Value = C.getRequest().ToString() + "/10";
            //        C.setRequest(C.getRequest() - 1);
            //    }
            //    else if (C.getRequest() <= 0)
            //    {
            //        dtconsumers.Rows[idC].Cells[1].Value = "libre";
            //        C.setRequest(0);
            //    }
            //}
        }

        void Disponibilidad() //maneja la disponibilidad de los threads
        {
            // while (libre)
            {
                if (disponibleP > 0)
                {
                    //codigo productor
                    P = productores.Peek();
                    P.Cantidad(cantidad);          //cantidad de instrucciones
                    P.setRequest(cantidad);
                    idP = P.getID();
                    ThreadPool.QueueUserWorkItem(new WaitCallback(P.produce));
                    productores.Enqueue(P);        //Agrega un objeto al final de Queue.
                    actualizartabla();
                }
                else
                {
                    //que hacer si no hay disponibilidad
                    scommand = origen + " " + destino;
                    instrucciones.Enqueue(scommand);
                }
                if (disponibleC > 0)
                {
                    //codigo consumidor
                    C = consumidores.Peek(); //Devuelve un objeto al principio de Queue sin eliminarlo.
                    ThreadPool.QueueUserWorkItem(new WaitCallback(C.consumeINS));
                    idC = C.getID();
                    C.setRequest(cantidad);
                    actualizartabla();
                    consumidores.Enqueue(C);           //Agrega un objeto al final de Queue.
                }
                else
                {
                    //que hacer si no hay disponibilidad
                    scommand = origen + " " + destino;
                    instrucciones.Enqueue(scommand);
                }

            }

        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            numeroC = Convert.ToInt32(txtcons.Text);
            numeroP = Convert.ToInt32(txtprod.Text);
            WC = new Worker(1, "Consumer", numeroC);
            WP = new Worker(2, "Producer", numeroP);
            //agregar consumers
            dtconsumers.Rows.Add(numeroC);
            for (int i = 0; i < 3; i++)
            {
                C = new Consumer(queue, lockObj, i, 0);
                consumidores.Enqueue(C); //se agrega a un cola para luego re usarlo
                dtconsumers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtconsumers.Rows[i].Cells[1].Value = "Libre";
                dtconsumers.Rows[i].Cells[2].Value = "0/10";
            }

            //agregar producers
            dtproducers.Rows.Add(numeroP);
            for (int i = 0; i < 3; i++)
            {
                P = new Producer(queue, i, 0);
                productores.Enqueue(P); //se agrega a un cola para luego re usarlo
                dtproducers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtproducers.Rows[i].Cells[1].Value = "Libre";
                dtproducers.Rows[i].Cells[2].Value = "0/10";
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            disponibleC = numeroC;
            disponibleP = numeroP;      // para saber cuantos consumidores y productores hay
            origen = Origen.Text;
            destino = Destino.Text;     //datos para sql
            cantidad = int.Parse(TxtCantidad.Text); //numero de veces que se ejecuta la instruccion
            disponibleP--;
            disponibleC--;              //manejo para saber cuantos hay disponibles
            WC.setDisponible(disponibleC);
            WP.setDisponible(disponibleP);      //para guardar cuantos hilos de cada tipo quedan disponibles
            Disponibilidad();           //
        }

        private void btremove_Click(object sender, EventArgs e)
        {

        }
    }
}

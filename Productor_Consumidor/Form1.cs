using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Productor_Consumidor
{
    public partial class fmWorker : Form
    {
        #region variables
        Object lockObj = new object();
        Queue<string> queue = new Queue<string>();
        int numeroC, numeroP, disponibleC, disponibleP;
        string destino, origen, scommand = "";
        Queue<string> instrucciones = new Queue<string>();
        Queue<Consumer> consumidores = new Queue<Consumer>();
        Queue<Producer> productores = new Queue<Producer>();
        bool libre = true;
        int cantidad=0;
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

        void crear(int tipo)
        {
            //0 para consumer
            // 1 para producer
            if (tipo == 0)
            {
                //C = new Consumer(queue, lockObj, "c" + numeroC.ToString());
                //ThreadPool.QueueUserWorkItem(new WaitCallback(C.consume));
                //numeroC++;
            }
            else
            {
                //P = new Producer(queue, "P" + numeroP.ToString());
                //P.produce(numeroP);
                //ThreadPool.QueueUserWorkItem(new WaitCallback(P.produce));
                //numeroP++;
            }
        }

        void actualizartabla()
        {
            //se actualiza la tabla
        }

        void Disponibilidad() //maneja la disponibilidad de los threads
        {
            while (libre)
            {
                if (disponibleC > 0)
                {
                    //codigo consumidor
                    Consumer c1 = consumidores.Peek(); //Devuelve un objeto al principio de Queue sin eliminarlo.
                    ThreadPool.QueueUserWorkItem(new WaitCallback(c1.consume));
                    consumidores.Enqueue(c1);           //Agrega un objeto al final de Queue.
                }
                else
                {
                    //que hacer si no hay disponibilidad
                    scommand = origen + " " + destino;
                    instrucciones.Enqueue(scommand);
                }
                if (disponibleP > 0)
                {
                    //codigo productor
                    Producer p1 = productores.Peek();
                    p1.Cantidad(cantidad);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(p1.produce));
                    productores.Enqueue(p1);        //Agrega un objeto al final de Queue.
                    libre = false;
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
                C = new Consumer(queue, lockObj, "C1");
                consumidores.Enqueue(C); //se agrega a un cola para luego re usarlo
                //C = new Consumer(queue, lockObj, "C1");
                dtconsumers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtconsumers.Rows[i].Cells[1].Value = "Libre";
                dtconsumers.Rows[i].Cells[2].Value = "0/10";
            }

            //agregar producers
            dtproducers.Rows.Add(numeroP);
            for (int i = 0; i < 3; i++)
            {
                P = new Producer(queue, "P1");
                productores.Enqueue(P); //se agrega a un cola para luego re usarlo
                dtproducers.Rows[i].Cells[0].Value = "Thread " + i.ToString();
                dtproducers.Rows[i].Cells[1].Value = "Libre";
                dtproducers.Rows[i].Cells[2].Value = "0/10";
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
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

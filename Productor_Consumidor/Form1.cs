using System;
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
    public partial class Form1 : Form
    {
        Object lockObj = new object();
        Queue<string> queue = new Queue<string>();
        int numeroC = 0;
        int numeroP = 0;

        Producer P;
        Consumer C;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main();
        }

        void main()
        {
            //productores
            for (int i = 0; i < 3; i++)
            {
                //P = new Producer(queue, "p" + i.ToString());
            }
            //consumidores
            for (int i = 0; i < 3; i++)
            {
                //C = new Consumer(queue, lockObj, "c" + i.ToString());
            }
        }
        private void btConsumer_Click(object sender, EventArgs e)
        {

        }

        private void btproducer_Click(object sender, EventArgs e)
        {

        }

        void crear(int tipo)
        {
            //0 para consumer
            // 1 para producer
            if (tipo == 0)
            {
                C = new Consumer(queue, lockObj, "c" + numeroC.ToString());
                ThreadPool.QueueUserWorkItem(new WaitCallback(C.consume));
                numeroC++;
            }
            else
            {
                P = new Producer(queue, "P" + numeroP.ToString());
                P.produce(numeroP);
                ThreadPool.QueueUserWorkItem(new WaitCallback(P.produce));
                numeroP++;
            }
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            numeroC = Convert.ToInt32(txtcons.Text);
            numeroP = Convert.ToInt32(txtprod.Text);
            dtproducers.Rows.Add(numeroP);
            dtconsumers.Rows.Add(numeroC);
            // Worker w1 = new Worker(1, "Consumer");
            //Worker w2 = new Worker(2, "Producer");
            //agregar consumers
            for (int i = 0; i < 3; i++)
            {
                C = new Consumer(queue, lockObj, "C1");
                dtconsumers.Rows[i].Cells["Cname"].Value = "1";
            }

            //agregar producers
            for (int i = 0; i < 3; i++)
            {
                P = new Producer(queue, "P1");
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        private void btremove_Click(object sender, EventArgs e)
        {

        }
    }
}

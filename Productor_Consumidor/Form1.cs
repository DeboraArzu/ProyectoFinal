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
        int numeroC = 4;
        int numeroP = 4;

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
            

            ThreadPool.SetMaxThreads(6, 6);
            //productores
            for (int i = 0; i < 3; i++)
            {
                P = new Producer(queue, "p" + i.ToString());
            }
            //consumidores
            for (int i = 0; i < 3; i++)
            {
                C = new Consumer(queue, lockObj, "c" + i.ToString());
            }
        }
        private void btConsumer_Click(object sender, EventArgs e)
        {
            crear(0);
        }

        private void btproducer_Click(object sender, EventArgs e)
        {
            crear(1);
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
    }
}

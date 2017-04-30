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
            Object lockObj = new object();
            Queue<string> queue = new Queue<string>();
            //productores
            Producer p1 = new Producer(queue);
            Producer p2 = new Producer(queue);
            Producer p3 = new Producer(queue);
            //consumidores
            Consumer c1 = new Consumer(queue, lockObj, "c1");
            Consumer c2 = new Consumer(queue, lockObj, "c2");
            Consumer c3 = new Consumer(queue, lockObj, "c3");

            //threads de los consumidores
            Thread t1 = new Thread(c1.consume);
            Thread t2 = new Thread(c2.consume);
            Thread t3 = new Thread(c3.consume);
            t1.Start();
            t2.Start();
            t3.Start();
            
            //threads de los productores
            Thread tp1 = new Thread(p1.produce);
            Thread tp2 = new Thread(p2.produce);
            Thread tp3 = new Thread(p3.produce);
            tp1.Start();
            tp2.Start();
            tp3.Start();
            

        }

        private void output_TextChanged(object sender, EventArgs e)
        {
            //holi
        }
    }
}

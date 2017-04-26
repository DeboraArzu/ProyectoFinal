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
            Producer p = new Producer(queue);
            Consumer c1 = new Consumer(queue, lockObj, "c1");
            Consumer c2 = new Consumer(queue, lockObj, "c2");

            Thread t1 = new Thread(c1.consume);
            Thread t2 = new Thread(c2.consume);
            t1.Start();
            t2.Start();

            Thread t = new Thread(p.produce);
            t.Start();

        }
    }
}

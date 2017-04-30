using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productor_Consumidor
{
    class Producer
    {
        public string estado;
        Queue<string> queue;
        TextBox txt;
        string item;
        int productionCycleCounter;
        public Producer(Queue<string> queue, TextBox txt)
        {
            this.queue = queue;
            this.txt = txt;
        }

        public void produce()
        {
            while (productionCycleCounter < 100)
            {
                productionCycleCounter += 1;// increase counter
                item = "item" + productionCycleCounter;
                queue.Enqueue(item);
                write();
                Console.WriteLine("Producing {0}", item);
            }
        }

        public void write()
        {
            txt.Text = "Producing " + item;
        }
    }
}

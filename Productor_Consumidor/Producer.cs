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
        public string id;
        Queue<string> queue;
        string item;
        int productionCycleCounter;
        int cantidadpro = 0; // puede usarse para otro proceso
        public Producer(Queue<string> queue, string id)
        {
            this.queue = queue;
            this.id = id;
        }

        public void produce(Object stateInfo, int cantidad)
        {
            //test
            while (productionCycleCounter < cantidad)
            {
                productionCycleCounter += 1;// increase counter
                item = "item" + productionCycleCounter;
                queue.Enqueue(item);
                //esto se debe de mandar a SQL
                //Console.WriteLine("Producing {0}", item);
                Console.WriteLine("Producer: " + id + " RUNNING " + item);
                estado = "Producer: " + id + " RUNNING " + item;
            }
            Console.WriteLine("Producer: " + id + "STOPPED ");
           estado = "Producer: " + id + "STOPPED ";
        }
    }
}

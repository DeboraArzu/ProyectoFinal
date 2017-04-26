using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productor_Consumidor
{
    class Producer
    {
        public string estado;
        Queue<string> queue;
        int productionCycleCounter;
        public Producer(Queue<string> queue)
        {
            this.queue = queue;
        }

        public void produce()
        {
            while (productionCycleCounter < 100)
            {
                productionCycleCounter += 1;// increase counter
                string item = "item" + productionCycleCounter;
                queue.Enqueue(item);
                //estado = "Producing " + item;
                Console.WriteLine("Producing {0}", item);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Productor_Consumidor
{
    class Consumer
    {
        Queue<string> queue;
        Object lockObject;
        string name;
        public Consumer(Queue<string> queue, Object lockObject, string name)
        {
            this.queue = queue;
            this.lockObject = lockObject;
            this.name = name;
        }

        public void consume()
        {
            Thread.Sleep(500);
            string item;
            while (true)
            {
                lock (lockObject)
                {
                    if (queue.Count == 0)
                    {
                        continue;
                    }
                    item = queue.Dequeue();
                    Console.WriteLine(" {0} Comsuming {1}", name, item);
                }
            }
        }

    }
}

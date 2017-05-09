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
        int name, request = 0;
        public string estado;
        public Consumer(Queue<string> queue, Object lockObject, int name, int request)
        {
            this.queue = queue;
            this.lockObject = lockObject;
            this.name = name;
            this.request = request;
        }

        public void consume()
        {
            Thread.Sleep(500);
            string item;
            while (true)
            {
                lock (lockObject)
                {
                    //seccion critica
                    if (queue.Count == 0)
                    {
                        // al entrar aqui se salta la parte de escribir porque no hay nada en la cola.
                        estado = "Consumer: " + name + " SLEEP ";
                        continue;
                    }
                    item = queue.Dequeue();
                    //estado = "Consumer " + name + "Consuming" + item;
                    //esto se debe de mandar a SQL
                    //Console.WriteLine(" {0} Comsuming {1}", name, item);
                    estado = "Consumer: " + name + " RUNNING, " + item;
                }
            }
        }

        public void consume(Object stateInfo)
        {
            //test
            Thread.Sleep(500);
            string item;
            while (true)
            {
                lock (lockObject)
                {
                    //seccion critica
                    if (queue.Count == 0)
                    {
                        // al entrar aqui se salta la parte de escribir porque no hay nada en la cola.
                        estado = "Consumer: " + name + " SLEEP ";
                        continue;
                    }
                    item = queue.Dequeue();
                    //estado = "Consumer " + name + "Consuming" + item;
                    //esto se debe de mandar a SQL
                    Console.WriteLine(" {0} Comsuming {1}", name, item);
                    estado = "Consumer: " + name + " RUNNING " + item;
                }
            }
        }

        public int getID()
        {
            return name;
        }

        public void setRequest(int request)
        {
            this.request = request;
        }

        public int getRequest()
        {
            return request;
        }
    }
}

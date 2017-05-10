using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productor_Consumidor
{
    class RoundRobin
    {
        int cantidadProducer, cantidadConsumer;
        int IDp, IDc;
        Queue<int> myqueueC = new Queue<int>();
        Queue<int> myqueueP = new Queue<int>();

        public RoundRobin(int cantidadProducer, int cantidadConsumer)
        {
            this.cantidadConsumer = cantidadConsumer;
            this.cantidadProducer = cantidadProducer;
            this.IDp = 0;
            this.IDc = 0;
            agregarIDs();
        }

        void agregarIDs() //se agregan los ID's a la cola
        {
            for (int i = 0; i < cantidadConsumer; i++)
            {
                myqueueC.Enqueue(i);
            }
            for (int i = 0; i < cantidadProducer; i++)
            {
                myqueueP.Enqueue(i);
            }
        }

        public void RoundRobinexe()
        {
            IDp = myqueueP.Dequeue();
            IDc = myqueueC.Dequeue();
        }

        public int getIDp()
        {
            return IDp;
        }
        public int getIDc()
        {
            return IDc;
        }

        public void returntoQueue(int idP, int idC) //regresa los valores a la cola
        {
            myqueueC.Enqueue(idC);
            myqueueP.Enqueue(idP);
        }
    }
}

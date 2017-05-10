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
        public int id;
        Queue<string> queue;
        string item;
        public int productionCycleCounter;
        bool libre;
        int cantidadpro = 0; // puede usarse para otro proceso
        public Producer(Queue<string> queue, int id, int request, bool libre)
        {
            this.queue = queue;
            this.id = id;
            this.libre = libre;
            this.estado = "Libre";
        }

        public void SetCantidadProducir(int cantidad) //se le dice cuantas veces tiene que entrar al while
        {
            cantidadpro = cantidad;
        }

        public void produce(Object stateInfo)
        {
            
            while (productionCycleCounter < cantidadpro)
            {
                productionCycleCounter += 1;// increase counter
                item = "item " + productionCycleCounter;
                queue.Enqueue(item);
                //esto se debe de mandar a SQL
                //Console.WriteLine("Producing {0}", item);
                Console.WriteLine("Producer: " + id + " RUNNING " + item);
                estado = " Running ";
            }
            Console.WriteLine("Producer: " + id + "STOPPED ");
            estado = "Libre";
        }

        public void setRequest(int request)
        {
            this.productionCycleCounter = request;
        }

        public int getID()
        {
            return id;
        }

        public int getProducction()
        {
            return productionCycleCounter;
        }

        public string getEstado()
        {
            return estado;
        }

        public int getProducctionTotal()
        {
            return cantidadpro; ;
        }
    }
}

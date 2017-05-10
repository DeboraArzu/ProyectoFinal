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
        int productionCycleCounter;
        bool libre;
        int cantidadpro, request = 0; // puede usarse para otro proceso
        public Producer(Queue<string> queue, int id, int request, bool libre)
        {
            this.queue = queue;
            this.id = id;
            this.request = request;
            this.libre = libre;
        }
        public void Cantidad(int cantidad)
        {
            cantidadpro = cantidad;
        }
        public void produce(Object stateInfo)
        {
            //test
            while (productionCycleCounter < cantidadpro)
            {
                productionCycleCounter += 1;// increase counter
                item = "item " + productionCycleCounter;
                queue.Enqueue(item);
                //esto se debe de mandar a SQL
                //Console.WriteLine("Producing {0}", item);
                Console.WriteLine("Producer: " + id + " RUNNING " + item);
                request = productionCycleCounter;
                estado = " Running ";
            }
            Console.WriteLine("Producer: " + id + "STOPPED ");
            estado = "Libre";
        }
        public void setRequest(int request)
        {
            this.request = request;
        }
        public int getID()
        {
            return id;
        }
        public int getRequest()
        {
            return request;
        }
        public string getEstado()
        {
            return estado;
        }
    }
}

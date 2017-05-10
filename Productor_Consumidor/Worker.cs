using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Productor_Consumidor
{
    public class Worker
    {
        protected int id;
        protected bool working;
        public int used, request;
        public string type, estado;
        Object lockObj = new object();
        Queue<string> queue = new Queue<string>();
        List<Consumer> consumidores = new List<Consumer>();
        List<Producer> productores = new List<Producer>();
        Consumer C;
        Producer P;

        public Worker(int id, string type, int disponible)
        {
            this.id = id;
            this.used = 0;
            this.used = disponible;
            this.type = type;
        }

        public int getId()
        {
            return id;
        }

        public void setDisponible(int disponible)
        {
            this.used = disponible;
        }

        public int getDisponible()
        {
            return used;
        }
        public void agregarConsumer(int id)
        {
            C = new Consumer(queue, lockObj, id, 0);
            consumidores.Add(C);
        }

        public void agregarProducer(int id)
        {
            P = new Producer(queue, id, 0);
            productores.Add(P);
        }

        public string getEstadoConsumidor(int id)
        {
            return consumidores[id].getEstado();
        }

        public string getEstadoProductor(int id)
        {
            return productores[id].getEstado();
        }

        public int getRequestConsumidor(int id)
        {
            return consumidores[id].getRequest();
        }
        public int getRequestProductores(int id)
        {
            return productores[id].getRequest();
        }
        public void agregarOrigenDestino(int id, string origen, string destino)
        {
            consumidores[id].setOrigenDestino(origen, destino);
        }

        public bool setAvaible()
        {
            return working;
        }
    }
}

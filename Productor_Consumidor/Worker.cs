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
        public string origen, destino = "";
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

        public void setOrigenyDestino(string origen, string destino)
        {
            this.origen = origen;
            this.destino = destino;
        }

        public int getDisponible()
        {
            return used;
        }

        public void agregarConsumer(int id, bool libre, Queue<string> queue, object lockObj)
        {
            C = new Consumer(queue, lockObj, id, 0, libre);
            consumidores.Add(C);
        }

        public void agregarProducer(int id, bool libre, Queue<string> queue)
        {
            P = new Producer(queue, id, 0, libre);
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

        public int getRequestConsumidor(int id) //obtiene el numero de elementos consumidos
        {
            return consumidores[id].getRequest();
        }

        public int getRequestProductores(int id) //obtine el production cycle
        {
            return productores[id].getProducction();
        }

        public int getRequestConsumidorTotal(int id) //obtiene el numero de elementos totales que debe de consumir
        {
            return consumidores[id].getTotalRquest();
        }

        public int getRequestProductorTotal(int id) //obtiene el numero de elementos ha producir total
        {
            return productores[id].getProducctionTotal(); ;
        }

        public void agregarOrigenDestino(int id, string origen, string destino)
        {
            consumidores[id].setOrigenDestino(origen, destino);
        }

        public bool setAvaible()
        {
            return working;
        }

        public void IniciarProcesosProd(int id)
        {
            P = productores[id];
            ThreadPool.QueueUserWorkItem(new WaitCallback(P.produce));
        }

        public void IniciarProcesosConsI(int id)
        {
            C = consumidores[id];
            ThreadPool.QueueUserWorkItem(new WaitCallback(C.consumeINS));
        }

        public void IniciarProcesosConsD(int id)
        {
            C = consumidores[id];
            ThreadPool.QueueUserWorkItem(new WaitCallback(C.consumeDLT));
        }

        public void sendCantidadProducers(int cantidad, int id)
        {
            productores[id].SetCantidadProducir(cantidad);
        }

        public void sendRequestConsumer(int cantidad, int id)
        {
            consumidores[id].setRequest(cantidad);
        }

        public bool getLibreConsumidor(int id)
        {
            return consumidores[id].getLibre();
        }
        public bool getLibreProductor(int id)
        {
            return productores[id].getLibre();
        }

        public void setLibreConsumidor(int id, bool libre)
        {
            consumidores[id].setLibre(libre);

        }
        public void setLibreProductor(int id, bool libre)
        {
            productores[id].setLibre(libre);

        }
    }
}

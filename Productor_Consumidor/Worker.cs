﻿using System;
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

        public void sendCantidad(int cantidad, int id)
        {
            productores[id].SetCantidadProducir(cantidad);
        }
        public void sendRequestConsumer(int cantidad, int id)
        {
            consumidores[id].setRequest(cantidad);
        }
    }
}

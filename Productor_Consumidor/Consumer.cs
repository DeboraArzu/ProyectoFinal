using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Productor_Consumidor
{
    class Consumer
    {
        ComandosSQL sql = new ComandosSQL();
        Queue<string> queue;
        Object lockObject;
        int iID, request, totalrequest = 0;
        public string estado, origen, destino;
        bool libre = true;
        public Consumer(Queue<string> queue, Object lockObject, int name, int request, bool libre)
        {
            this.queue = queue;
            this.lockObject = lockObject;
            this.iID = name;
            this.request = request;
            origen = "";
            destino = "";
            estado = "Libre";
            this.libre = libre;
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
                        estado = "Consumer: " + iID + " SLEEP ";
                        continue;
                    }
                    item = queue.Dequeue();
                    //estado = "Consumer " + name + "Consuming" + item;
                    //esto se debe de mandar a SQL
                    //Console.WriteLine(" {0} Comsuming {1}", name, item);
                    estado = "Consumer: " + iID + " RUNNING, " + item;
                }
            }
        }

        public void consumeINS(Object stateInfo)
        {
            //test
            Thread.Sleep(500);
            string item;
            while (true)
            {
                lock (lockObject)
                {
                    //seccion critica
                    if (queue.Count < request) //que la cantidad sea igual a la producida, cantidad original 0 si es 0 no puede consumir una vez sea distinto comenzara a consumir lo que se produzca
                    {
                        // al entrar aqui se salta la parte de escribir porque no hay nada en la cola.
                        estado = "Sleep ";
                        continue;
                    }
                    if (queue.Count != 0)
                    {
                        item = queue.Dequeue();
                        request--;
                        Console.WriteLine(" {0} Comsuming {1}", iID, item);
                        //sentencia de SQL para insertar
                        sql.insertData(totalrequest, origen, destino);
                        estado = "Running ";
                    }

                }
            }
        }

        public void consumeDLT(Object stateInfo)
        {
            //test
            Thread.Sleep(500);
            string item;
            while (true)
            {
                lock (lockObject)
                {
                    //seccion critica
                    if (queue.Count < request)
                    {
                        // al entrar aqui se salta la parte de escribir porque no hay nada en la cola.
                        estado = "SLEEP ";
                        continue;
                    }
                    item = queue.Dequeue();
                    Console.WriteLine(" {0} Comsuming {1}", iID, item);
                    //sentencia de SQL para eliminar
                    sql.deleteData(origen, destino);
                    estado = "RUNNING ";
                }
            }
        }

        public int getID()
        {
            return iID;
        }

        public void setRequest(int request)
        {
            this.request = request;
            this.totalrequest = request;
        }
        public void setOrigenDestino(string origen, string destino)
        {
            this.origen = origen;
            this.destino = destino;
        }

        public int getRequest()
        {
            return request;
        }

        public int getTotalRquest()
        {
            return totalrequest;
        }
        public string getEstado()
        {
            return estado;
        }
        public bool getLibre()
        {
            return libre;
        }
        public void setLibre(bool libre)
        {
            this.libre = libre;
        }
    }
}

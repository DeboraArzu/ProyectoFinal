using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productor_Consumidor
{
    class Pool
    {
        public List<fmWorker> producer;
        public List<fmWorker> consumer;
        int maximo;
        int count;
        bool estado = false;

        public int maxSize = 6;
        //agregar comando sql
        public RoundRobin RR;

        private Pool(int producerparam, int consumerparam)
        {
            RR = new RoundRobin();
            this.producer = new List<fmWorker>();
            this.consumer = new List<fmWorker>();
            this.maximo = 6;
        }

        bool agregar()
        {
            if (count < maximo)
            {
                count++;
            }
            return estado;
        }

        bool eliminiar()
        {
            count--;
            return estado;
        }
        //agregar intrucciones de SQL
    }
}

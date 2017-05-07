using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productor_Consumidor
{
    class Pool
    {
        public List<Worker> producer;
        public List<Worker> consumer;
        int maximo;
        bool estado = false;

        public int maxSize = 6;
        //agregar comando sql
        public RoundRobin RR;

        private Pool(int producerparam, int consumerparam, int maximo)
        {
            RR = new RoundRobin();
            this.producer = new List<Worker>();
            this.consumer = new List<Worker>();
            this.maximo = maximo;
        }

        bool agregar()
        {
            return estado;
        }

        //agregar intrucciones de SQL
    }
}

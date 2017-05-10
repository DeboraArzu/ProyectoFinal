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

        public RoundRobin(int cantidadProducer, int cantidadConsumer)
        {
            this.cantidadConsumer = cantidadConsumer;
            this.cantidadProducer = cantidadProducer;
            this.IDp = 0;
            this.IDc = 0;
        }

        public int getIDp()
        {
            return IDp;
        }
        public int getIDc()
        {
            return IDc;
        }
    }
}

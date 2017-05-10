using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productor_Consumidor
{
    class Comandos
    {
        string instruccion; //delete o insert
        string origen, destino;

        public Comandos(string instruccion, string origen, string destino)
        {
            this.instruccion = instruccion;
            this.origen = origen;
            this.destino = destino;
        }

        public string getInstruccion()
        {
            return instruccion;
        }

        public string getDestino()
        {
            return destino;
        }
        public string getOrigen()
        {
            return origen;
        }
    }
}

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
        protected Thread thread;
        public int used;
        public string type;

        public Worker(int id, string type, int disponible)
        {
            this.id = id;
            this.used = 0;
            //this.thread.Name = type;
            this.used = disponible;
            this.type = type;
         //   this.thread.Start();
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

        public bool getWorking()
        {
            return working;
        }

        public string getStatus()
        {
            return thread.ThreadState.ToString();
        }

        public void remove()
        {
            this.thread.Abort();
        }
    }
}

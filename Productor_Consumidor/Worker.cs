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

        public Worker(int id, string type)
        {
            this.id = id;
            this.used = 0;
            this.thread.Name = "Thread ";
            this.type = type;
            this.thread.Start();
        }

        public int getId()
        {
            return id;
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

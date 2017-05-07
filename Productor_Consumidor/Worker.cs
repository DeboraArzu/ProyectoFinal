﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Productor_Consumidor
{
    interface Worker
    {
        void work();
    }
    public abstract class PCWorker : Worker
    {
        protected int id;
        protected bool working;
        protected Thread thread;
        public int total, used;
        public string type;

        public PCWorker(int id, int total, string type)//, SQL cmd
        {
            this.id = id;
            this.total = total;
            this.used = 0;
            this.thread = new Thread(this.work);
            this.thread.Name = "Thread " + type + " "+ this.id;
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

        public abstract void work();

        public void remove()
        {
            this.thread.Abort();
        }
    }
}

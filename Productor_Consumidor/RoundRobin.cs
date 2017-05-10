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
        Queue<int> myqueueC = new Queue<int>();
        Queue<int> myqueueP = new Queue<int>();
        float NumeroDeVeces = 0;
        float a1 = 0, a2 = 0, a3 = 0; // porcentaje de uso
        float n1 = 0, n2 = 0, n3 = 0; // numero de veces que se a usado el thread
        float p1 = 50, p2 = 30, p3 = 20; // porcentaje que le asignas
        int i = 0;

        public RoundRobin(int cantidadProducer, int cantidadConsumer)
        {
            this.cantidadConsumer = cantidadConsumer;
            this.cantidadProducer = cantidadProducer;
            this.IDp = 0;
            this.IDc = 0;
            agregarIDs();
        }

        void agregarIDs() //se agregan los ID's a la cola
        {
            for (int i = 0; i < cantidadConsumer; i++)
            {
                myqueueC.Enqueue(i);
            }
            for (int i = 0; i < cantidadProducer; i++)
            {
                myqueueP.Enqueue(i);
            }
        }

        public void RoundRobinexe()
        {
            //coloca aqui 
            //while (i < 100)
            //{
                if (NumeroDeVeces == 0)
                {
                    Console.WriteLine("Prooceso en 1");
                    NumeroDeVeces++;
                    n1++;
                    i++;
                }
                else
                {
                    a1 = (n1 / NumeroDeVeces) * 100;
                    a2 = (n2 / NumeroDeVeces) * 100;
                    a3 = (n3 / NumeroDeVeces) * 100;
                    if (a1 > p1/*|| EstadoP1==Running*/)
                    {
                        if (a2 > p2/*|| EstadoP2==Running*/)
                        {
                            if (a3 > p3/*|| EstadoP3==Running*/)
                            {
                                /*if(EstadoP1==Running)
                                 * {
                                 *     Console.WriteLine("Se guarda en cola");
                                 * }
                                 * else
                                 * {
                                 *      Console.WritLine("Se ejecuta en P1")
                                 *      n1++;
                                 *      i++;
                                 * }
                                */
                                Console.WriteLine("Se guarda en cola");
                            }
                            else
                            {
                                //ejecuta thread 3
                            //    Console.WriteLine("Proceso en 3");
                                IDp = 2;
                                IDc = 2; 
                                NumeroDeVeces++;
                                n3++;
                                i++;
                            }
                        }
                        else
                        {
                            //ejecuta thread 2
                            //Console.WriteLine("Proceso en 2");
                            IDp = 1;
                            IDc = 1;
                            NumeroDeVeces++;
                            n2++;
                            i++;
                        }
                    }
                    else
                    {
                        //ejecuta thread 1
                        //Console.WriteLine("Proceso en 1");
                        IDp = 0;
                        IDc = 0;
                        NumeroDeVeces++;
                        n1++;
                        i++;
                    }
                }
  //          }
            IDp = myqueueP.Dequeue();
            IDc = myqueueC.Dequeue();
        }

        public int getIDp()
        {
            return IDp;
        }
        public int getIDc()
        {
            return IDc;
        }

        public void returntoQueue(int idP, int idC) //regresa los valores a la cola
        {
            myqueueC.Enqueue(idC);
            myqueueP.Enqueue(idP);
        }
    }
}

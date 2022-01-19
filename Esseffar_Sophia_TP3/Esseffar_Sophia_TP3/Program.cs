using System;
using System.Threading;

namespace Esseffar_Sophia_TP3
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Exercise1.queries();

            
            /*
            
            Mutex mut = new Mutex();


            var t1 = new Thread(f1 => print(' ', 50, 10,mut));
            var t2 = new Thread(f2 => print('*', 40, 11, mut));
            var t3 = new Thread(f3 => print('°', 20, 9,mut));


            t1.Start();
            t2.Start();
            t3.Start();


            t1.Join();
            t2.Join();
            t3.Join();

            */
        }

        public static void print(char v1, int time, int duration, Mutex mut)
        {
            int nb = (duration*1000) / time;

            for (int i = 0; i <= nb; i++)
            {
                mut.WaitOne();
                Console.Write(v1);
                mut.ReleaseMutex();
                Thread.Sleep(time);
            }
        }

    }
}

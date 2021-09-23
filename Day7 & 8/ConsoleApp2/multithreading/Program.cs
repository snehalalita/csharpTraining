using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithreading
{
    
    class Program
    {
        public static void find_odd(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Odd number:" + i);
                }
            }
        }
        public static void find_even(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even number:" + i);
                }
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("start main");
            //Thread t1 = new Thread(()=>find_even(10));

            //Thread t2 = new Thread(() => find_odd(10));

            //t1.Start();
            //t2.Start();

            Task ta1 = new Task(()=>find_even(10));
            Task ta2 = new Task(() => find_odd(10));
            Task.Run(() => find_even(10));
            Task.Run(() => find_odd(10));

            Console.WriteLine("end main");
            Console.ReadLine();

        }
    }
}

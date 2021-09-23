using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallelDemo
{
    class Program
    {
        public void open(int totalSize)
        {

            if (!Directory.Exists(@"C:\Training\c#\ConsoleApp1\files"))
            {
                Console.WriteLine("The directory does not exist.");
                return;
            }
            String[] files = Directory.GetFiles(@"C:\Training\c#\ConsoleApp1\files");
            Parallel.For(0, files.Length, index =>
            {
                FileInfo fi = new FileInfo(files[index]);
                int size = Convert.ToInt32(fi.Length);
                Interlocked.Add(ref totalSize, size);
            });
            Console.WriteLine("Directory '{0}':", "DirectoryName");
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
        }

        public void fopen()
        {

            //File.Open(@"C:\Training\c#\ConsoleApp1\files\networklog.txt", FileMode.Open);
            string[] text = File.ReadAllLines(@"C:\Training\c#\ConsoleApp1\files\networklog.txt");
            Parallel.For(0, text.Length, i =>
            {
                Console.WriteLine("Thread:"+Thread.CurrentThread.ManagedThreadId+" "+text[i]);
                Thread.Sleep(300);

            });

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.fopen();
           /* Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Start Time");
            DateTime t1 = DateTime.Now;
            Console.WriteLine(t1);
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("even number:" + i + " Thread:" + Thread.CurrentThread.ManagedThreadId);
                }
                else
                {
                    Console.WriteLine("odd number:" + i + " Thread:" + Thread.CurrentThread.ManagedThreadId);
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine("End Time");
            DateTime t2 = DateTime.Now;
            Console.WriteLine(t2);

            TimeSpan ts = t2 - t1;
            Console.WriteLine("Time taken=" + ts.TotalSeconds);
            Console.WriteLine();

            Console.WriteLine("Start Time");
            DateTime t3 = DateTime.Now;
            Console.WriteLine(t3);
            Parallel.For(0, n, i =>
              {
                  if (i % 2 == 0)
                  {
                      Console.WriteLine("even number:" + i + " Thread:" + Thread.CurrentThread.ManagedThreadId);
                  }
                  else
                  {
                      Console.WriteLine("odd number:" + i + " Thread:" + Thread.CurrentThread.ManagedThreadId);
                  }
                  Thread.Sleep(100);
              });
            Console.WriteLine("End Time");

            DateTime t4 = DateTime.Now;
            Console.WriteLine(t4);

            TimeSpan ts1 = t4 - t3;
            Console.WriteLine("Time taken=" + ts1.TotalSeconds);*/

            Console.ReadLine();
        }

    }
}

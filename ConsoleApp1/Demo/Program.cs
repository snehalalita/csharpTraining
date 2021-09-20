using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static public void swap(int n1,int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

        static public void swap1(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

        static void Main(string[] args)
        {
            int n1 = 30,n2=100;
            swap(n1,n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine();

            swap1(ref n1, ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);


            Console.Read();

            var bin = new FormatException();
        }
    }
}

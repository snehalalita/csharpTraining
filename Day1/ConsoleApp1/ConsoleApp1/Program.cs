using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1, val2, val3;

            Console.WriteLine("Enter value 1:");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value 2:");
            val2 = Convert.ToInt32(Console.ReadLine());

            val3 = val1 + val2;
            Console.WriteLine("Addition : " + (val1 + val2));

            val3 = val1 - val2;
            Console.WriteLine("Subtraction : " + val3);

            val3 = val1 * val2;
            Console.WriteLine("Multiplication : " + val3);

            val3 = val1 / val2;
            Console.WriteLine("Division : " + val3);

             Console.Read();
        }
    }
}

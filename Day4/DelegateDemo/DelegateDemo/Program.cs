using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            mydel mydelegate = new mydel(sum);
            int res = mydelegate(3, 5);
            Console.WriteLine(res);

            Console.Read();

        }
    }
}

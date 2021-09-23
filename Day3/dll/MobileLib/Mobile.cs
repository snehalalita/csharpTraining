using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLib
{
    public class Mobile
    {
        public void Mobiletype()
        {
            Console.WriteLine("Types");
            Console.WriteLine("Android");
            Console.WriteLine("Mac");
        }
        public static void get_mobile(int num)
        {
            if (num < 8)
            {
                Console.WriteLine("less than 8");
            }
            else
            {
                Console.WriteLine("more");
            }
        }
    }
}

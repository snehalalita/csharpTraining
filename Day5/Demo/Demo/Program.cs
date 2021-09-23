using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace day5
{
    class Program
    {
        static void sum(ArrayList arr)
        {
            Console.WriteLine("ArrayList:");
            int total = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
                total = total + Convert.ToInt32(arr[i]);
            }
            Console.WriteLine("Sum=" + total);
        }

        static void disp(ArrayList arr, int len)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].ToString().Length == len)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        static void Main(string[] args)

        {
            ArrayList al = new ArrayList() { 2, 4, 52, 634, 12, 421, 12, 123, 12, 32, 4, 2 };

            sum(al);

            Console.WriteLine();

            ArrayList astr = new ArrayList() { "sneha", "abcde", "qwert", "ghjkl", "poilk", "jsuhdyf" };

            Console.WriteLine("Enter the length of the word");
            int len = Convert.ToInt32(Console.ReadLine());

            disp(astr, len);

            Console.WriteLine();

            Rectangle rect = new Rectangle(4, 3, "black");
            rect.disp();
            Console.WriteLine();

            Shape1[] sh = { new Cube(), new Circle() };
            Console.WriteLine("Area of cube is " + sh[0].area());
            Console.WriteLine("Volume of cube is " + sh[0].volume());

            Console.WriteLine("Area of circle is " + sh[1].area());
            Console.WriteLine("Volume of circle is " + sh[1].volume());

            /*Cube c = new Cube();
            Console.WriteLine("Area of cube is "+c.area());
            Console.WriteLine("Volume of cube is " + c.volume());

            Circle cr = new Circle();
            Console.WriteLine("Area of circle is " + cr.area());
            Console.WriteLine("Volume of circle is " + cr.volume());*/

            Console.Read();
        }
    }
}

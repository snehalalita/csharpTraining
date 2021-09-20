using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MobileLib;

namespace ConsoleApp1
{
    class Program
    {
        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            Collection cl= new Collection();
            cl.diff();
            /*mydel mydelegate = new mydel(sum);
            int res = mydelegate(3, 5);
            Console.WriteLine(res);*/
            
            /* Day3Ex obj = new Day3Ex();
            //obj.create_file();
            //obj.remove_file();
            //obj.open_file();
            //obj.add_text();
            //obj.read_file();
            //obj.display_contents();
            obj.count_lines();*/
            
            //Mobile.get_mobile(7);
            /*Mobile obj = new Mobile();
            obj.Mobiletype();*/


            
            
            
            /*Day2Ex fobj = new Day2Ex();
            //fobj.read_input();

            fobj.read_network();*/
            
            /*FileHandling obj = new FileHandling();
            //String s=obj.writeFile();
            int r = obj.readFile();*/


           /* int val1, val2, val3;

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
            Console.WriteLine("Division : " + val3);*/

            Console.Read();
        }
    }
}

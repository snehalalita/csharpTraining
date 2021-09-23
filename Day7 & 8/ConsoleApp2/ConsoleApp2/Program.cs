using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp2
{
    class Program
    {
        //Dictionary Handson

        static void Main(String[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "player5");
            d.Add(2, "player1");
            d.Add(3, "player3");
            d.Add(4, "player2");
            d.Add(5, "player4");

            foreach (var item in d)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            
            Console.WriteLine("\nNumber of players:" + d.Count);

            d[1] = "player4";
            d[5] = "player5";

            foreach (var item in d)
            {
                Console.WriteLine(item.Key+ " : " + item.Value);
            }

            d.Clear();
            Console.WriteLine("\nNumber of players:" + d.Count);
            Console.ReadLine();
        }
    }
}


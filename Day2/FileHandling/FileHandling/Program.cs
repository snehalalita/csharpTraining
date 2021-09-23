using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Example e = new Example();
            e.read_input();
            Console.WriteLine();
            e.read_network();

            //FileHandle fileHandle = new FileHandle();
            //String s =fileHandle.writeFile();
            //int r = fileHandle.readFile();

            Console.ReadLine();

        }
    }
}

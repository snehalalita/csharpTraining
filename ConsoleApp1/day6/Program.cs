﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace day6
{
    [Serializable]
    class Program
    {

        static void Main(string[] args)
        {
            //tutorial tut = new tutorial();
            //tut.cr();

            Person.ob();

            //var binaryFormatter = new BinaryFormatter();
            //Stream fs = new FileStream(@"C:\Training\c#\ConsoleApp1\files\person.txt", FileMode.Open, FileAccess.Read);
            //Person p1 = (Person)binaryFormatter.Deserialize(fs);
            //p1.toString();
            //Console.ReadLine();
        }
    }
}

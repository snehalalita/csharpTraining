using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
   [Serializable]

        public class City
        {
            public string name;
            public int population;
        }

    [Serializable]
        public class Person
        {
            public string name;
            public int age;
            public City city = new City();

            public void toString()
            {
                Console.WriteLine(this.name);
                Console.WriteLine(this.age);
                Console.WriteLine(this.city.name);
                Console.WriteLine(this.city.population);

            }
            public static void ob()
            {
                Person per = new Person();
                per.name = "sneha";
                per.age = 21;
                per.city.name = "blr";
                per.city.population = 32;


            var binaryFormatter = new BinaryFormatter();
            Stream fs = new FileStream(@"C:\Training\csharpTraining\Day6\files\person.txt", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fs, per);
            fs.Close();

            //XmlSerializer serialization = new XmlSerializer(typeof(Person));
            //    serialization.Serialize(Console.Out, per);
            //    Console.ReadLine();




            Console.Read();
            }
        }
}

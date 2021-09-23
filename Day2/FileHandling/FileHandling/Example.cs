using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Example
    {
        public void read_input()
        {
            FileStream fs = new FileStream(@"C:\Training\csharpTraining\Day2\files\course.txt", FileMode.Create, FileAccess.Write);
            StreamWriter fw = new StreamWriter(fs);
            Console.WriteLine("COURSE DETAILS");
            Console.WriteLine("Enter the number of courses:");
            int n = Convert.ToInt32(Console.ReadLine());
            fw.WriteLine("Number of courses:" + n);
            fw.WriteLine("*******************************");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Register Number:");
                int regno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Course:");
                String course = Console.ReadLine();
                Console.Write("Enter Title:");
                String title = Console.ReadLine();

                fw.WriteLine("Regno:" + regno);
                fw.WriteLine("Course:" + course);
                fw.WriteLine("Title:" + title);
                fw.WriteLine();
            }
            fw.Close();
            fs.Close();

        }

        public void read_network()
        {

            FileStream fs = new FileStream(@"C:\Training\csharpTraining\Day2\files\network.txt", FileMode.Open, FileAccess.Read);

            Console.WriteLine("SOURCE\t\tDESTINATION\t\tDATE\t\tCALL STATUS");
            StreamReader fr = new StreamReader(fs);

            while (fr.Peek() > 0)
            {
                string line = fr.ReadLine();
                if (line.Contains(":"))
                {
                    char[] ch = { ':' };
                    string[] words = line.Split(ch, 2);
                    for (int j = 1; j < words.Length; j++)
                    {
                        Console.Write(words[j] + "\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }


            fr.Close();
            fs.Close();
        }
    }
}

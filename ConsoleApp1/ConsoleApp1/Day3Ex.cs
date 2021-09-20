using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Day3Ex
    {
        public void create_file()
        {
            FileStream fs = new FileStream(@"C:\Training\c#\ConsoleApp1\files\day3.txt", FileMode.Create, FileAccess.Write);
            Console.WriteLine("A file created with name day3.txt");
            fs.Close();
        }

        public void remove_file()
        {
            string[] files = Directory.GetFiles(@"C:\Training\c#\ConsoleApp1\files");
            Console.WriteLine("List of files:");
            
            for (int i=0; i < files.Length; i++)
            {
                Console.WriteLine((i + 1) + "  " + files[i]);
            }
            Console.WriteLine("Pick a file to remove");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= files.Length)
            {
                File.Delete(files[num - 1]);
                Console.WriteLine("File deleted successfully" + files[num - 1]);
            }
            else
            {
                Console.WriteLine("File doesnt exist.");
            }
        }

        public void open_file()
        {
            Console.WriteLine("Open File:");
            string name = Console.ReadLine();
            if(File.Exists(@"C:\Training\c#\ConsoleApp1\files\"+name))
            {
                Console.WriteLine("File exists");
                FileStream f = new FileStream(@"C:\Training\c#\ConsoleApp1\files\"+name, FileMode.Open, FileAccess.Read);
                StreamReader fr = new StreamReader(f);

                Console.WriteLine("Contents of my file:");
                while (fr.Peek() > 0)
                {
                    string line = fr.ReadLine();
                    Console.WriteLine(line);

                }


            }
            else
            {
                FileStream fs = new FileStream(@"C:\Training\c#\ConsoleApp1\files\day3.txt", FileMode.Create, FileAccess.Write);
                Console.WriteLine("File created");
            }
        }

        public void add_text()
        {
            FileStream fs = new FileStream(@"C:\Training\c#\ConsoleApp1\files\day3.txt", FileMode.Create, FileAccess.Write);
            StreamWriter fw = new StreamWriter(fs);

            fw.WriteLine("hello");
            fw.WriteLine("hey");
            fw.WriteLine("welcome");
            
            fw.Close();
            fs.Close();

            Console.WriteLine("A file created with content - day3.txt");
        }

        public void read_file()
        {
            FileStream fs = new FileStream(@"C:\Training\c#\ConsoleApp1\files\day3.txt", FileMode.Create, FileAccess.Write);
            StreamWriter fw = new StreamWriter(fs);

            fw.WriteLine("hello");
            fw.WriteLine("hey");
            fw.WriteLine("welcome");

            fw.Close();
            fs.Close();
            FileStream f = new FileStream(@"C:\Training\c#\ConsoleApp1\files\day3.txt", FileMode.Open, FileAccess.Read);
            StreamReader fr = new StreamReader(f);

            Console.WriteLine("Contents of my file:");
            while (fr.Peek() > 0)
            {
                string line = fr.ReadLine();
                Console.WriteLine(line);

            }
               
        }

        public void display_contents()
        {
            FileStream fs = new FileStream(@"C:\Training\c#\ConsoleApp1\files\day3.txt", FileMode.Create, FileAccess.Write);
            StreamWriter fw = new StreamWriter(fs);
            Console.WriteLine("Enter the number of strings:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the strings:");
            string[] words = new string[num];
            for (int i = 0; i < num; i++)
            {
                words[i]= Console.ReadLine();
                fw.WriteLine(words[i]);
            }
            fw.Close();
            fs.Close();

            FileStream f = new FileStream(@"C:\Training\c#\ConsoleApp1\files\day3.txt", FileMode.Open, FileAccess.Read);
            StreamReader fr = new StreamReader(f);

            Console.WriteLine("Enter the string number to be displayed:");
            int strnum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <strnum; i++)
            {
                string line = fr.ReadLine();
            }
            Console.WriteLine(fr.ReadLine());
        }

        public void count_lines()
        {
            FileStream f = new FileStream(@"C:\Training\c#\ConsoleApp1\files\day3.txt", FileMode.Open, FileAccess.Read);
            StreamReader fr = new StreamReader(f);

            Console.WriteLine("Contents:");
            int count = 0;
            while (fr.Peek() > 0)
            {
                Console.WriteLine(fr.ReadLine());
                count++;

            }
            Console.WriteLine("No of lines =" + count);

        }
    }
}

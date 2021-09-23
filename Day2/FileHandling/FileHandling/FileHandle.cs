using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class FileHandle
    {
        public String writeFile()
        {
            FileStream fs = new FileStream(@"C:\Training\csharpTraining\Day2\files\temp.txt", FileMode.Create, FileAccess.Write);
            StreamWriter fw = new StreamWriter(fs);

            fw.WriteLine("hello");
            fw.WriteLine("hey");
            fw.WriteLine("welcome");
            Console.WriteLine("File created");
            fw.Close();
            fs.Close();
            return "File Created";
        }

        public int readFile()
        {
            string[] files = Directory.GetFiles(@"C:\Training\csharpTraining\Day2\files");
            for (int i = 0; i < files.Length; i++)
            {
                FileStream fs = new FileStream(files[i], FileMode.Open, FileAccess.Read);
                StreamReader fr = new StreamReader(fs);

                while (fr.Peek() > 0)
                {
                    string line = fr.ReadLine();
                    if (line.Contains(":"))
                    {
                        string[] words = line.Split(':');
                        for (int j = 0; j < words.Length; j++)
                        {
                            Console.WriteLine(words[j]);
                        }
                    }
                    else
                    {
                        Console.WriteLine(line);
                    }
                }
                fr.Close();
                fs.Close();
            }
            return 0;
        }
    }
}

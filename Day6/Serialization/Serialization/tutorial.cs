using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{

    [Serializable]
    class tutorial
    {
        public int ID;
        public string name;

        public void cr()
        {
            tutorial t = new tutorial();
            t.ID = 1;
            t.name = "Asda";

            var binaryFormatter = new BinaryFormatter();
            Stream fs = new FileStream(@"C:\Training\csharpTraining\Day6\files\tutorial.txt", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fs, t);
            fs.Close();

            fs = new FileStream(@"C:\Training\csharpTraining\Day6\files\tutorial.txt", FileMode.Open, FileAccess.Read);
            tutorial t1 = (tutorial)binaryFormatter.Deserialize(fs);
            Console.WriteLine(t1.ID);
            Console.WriteLine(t1.name);


            Console.Read();
        }
    }
}

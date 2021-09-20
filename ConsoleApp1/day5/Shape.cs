using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    abstract class Shape
    {
        string color;

        public void setColor(string str)
        {
            this.color = str;
        }

        public string getColor()
        {
            return this.color;
        }

        public abstract double area();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class Rectangle : Shape
    {
        int length;
        int width;

        public Rectangle(int l, int w, string c)
        {
            setColor(c);
            length = l;
            width = w;
        }

        public override double area()
        {
            return length * width;
        }

        public void disp()
        {
            Console.WriteLine("Area=" + area());
        }
    }
}

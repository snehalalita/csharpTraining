using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    public interface Shape1
    {
        double area();
        double volume();

    }
    class prog3
    {
    }

    public class Cube : Shape1
    {
        int x = 10;
        public double area()
        {
            return 6 * x * x;
        }

        public double volume()
        {
            return x * x * x;
        }
    }

    public class Circle : Shape1
    {
        int radius = 10;
        public double area()
        {
            return Math.PI * radius * radius;
        }

        public double volume()
        {
            return 0;
        }

    }
}

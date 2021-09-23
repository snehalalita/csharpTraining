using MobileLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile.get_mobile(7);
            Mobile obj = new Mobile();
            obj.Mobiletype();
        }
    }
}

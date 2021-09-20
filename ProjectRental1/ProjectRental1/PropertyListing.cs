using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRental1
{
    
        [Serializable]
        public class PropertyListing
        {
            private Property[] prop = new Property[100];

            public Property this[int i]
            {
                get { return prop[i]; }
                set { prop[i] = value; }
            }
        }
    
}

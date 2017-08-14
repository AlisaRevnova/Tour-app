using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Holiday
{
    [Serializable]
    public class Tour
    {
        public string direction;
        public Resorts hotel;
        public DateTime depart;
        public DateTime arrive;

        public Tour(string d, Resorts h, DateTime dep, DateTime ar)
        {
            direction = d;
            hotel = h;
            depart = dep;
            arrive = ar;
        }
    }
}

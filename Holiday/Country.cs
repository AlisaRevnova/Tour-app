using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Holiday
{
    [Serializable]
    public class Country
    {
        public string country { get; set; }
        public List<Resorts> allHotels = new List<Resorts>();

        public Country(string c, params Resorts[]r)
        {
            country = c;
            foreach(var i in r)
            {
                allHotels.Add(i);
            }
        }
    }
}

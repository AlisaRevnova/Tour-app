using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Holiday
{
    [Serializable]
    public class Resorts
    {
        public string Resort { get; set; }
        public int stars { get; set; }

        public Resorts(string r)
        {
            Resort = r;
        }
        public Resorts(string r, int s)
        {
            Resort = r;
            stars = s;
        }
    }
}

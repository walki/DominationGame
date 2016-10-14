using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Army
    {
        public Country HomeCountry { get; set; }
        public Country Destination { get; set; }
        public Player Owner { get; set; }
    }
}

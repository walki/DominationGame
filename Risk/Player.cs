using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Player
    {
        public int Color { get; set; }

        public List<Country> Countries { get; set; }
        public List<Army> Armies { get; set; }
    }
}

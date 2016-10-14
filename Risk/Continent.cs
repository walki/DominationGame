using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public enum ContinentName
    {
        NorthAmerica,
        SouthAmerica,
        Europe,
        Africa,
        Asia,
        Australia
    }

    public class Continent
    {
        public List<Country> Countries { get; set; }
        public ContinentName Name { get; set; }

       
        public Continent(ContinentName name)
        {
            Name = name;
            Countries = new List<Country>();
        }

    }
}

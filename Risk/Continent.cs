using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public enum ContinentName
    {
        NorthAmerica = 1,
        SouthAmerica,
        Europe,
        Africa,
        Asia,
        Australia
    }

    public class Continent
    {

        public int Id { get; set; }
        public List<Country> Countries { get; set; }
        public ContinentName Name { get; set; }
        public int ArmyBonus { get; set; }

        public Continent(ContinentName name)
        {
            Name = name;
            Id = (int)name;
            Countries = new List<Country>();
        }

    }
}

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

        public ContinentName Id { get; set; }
        public List<Country> Countries { get; set; }
        public String Name
        {
            get
            {
                return Id.ToString();
            }
            

        }
        public int ArmyBonus { get; set; }

        public Continent(ContinentName name, int armyBonus)
        {
            Id = name;
            Countries = new List<Country>();
            ArmyBonus = armyBonus;
        }

    }
}

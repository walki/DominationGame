using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public enum CountryName
    {
        Alaska = 1,
        NorthWestTerritory,
        Greenland,
        Alberta,
        Ontario,
        Quebec,
        WesternUnitedStates,
        EasternUnitedStates,
        CentralAmerica,

        Venezuela,
        Peru,
        Brazil,
        Argentina,

        Iceland,
        Scandinavia,
        GreatBritain,
        NorthernEurope,
        Ukraine,
        WesternEurope,
        SouthernEurope,

        NorthAfrica,
        Egypt,
        EastAfrica,
        Congo,
        SouthAfrica,
        Madagascar,

        Ural,
        Siberia,
        Yakutsk,
        Kamchatka,
        Irkutsk,
        Mongolia,
        Japan,
        Afghanistan,
        China,
        MiddleEast,
        India,
        Siam,

        Indonesia,
        NewGuinea,
        WesternAustralia,
        EasternAustralia

    }


    public class Country
    {
        public List<CountryName> Neighbors
        {
            get;
            set;
        }

        public List<Army> Armies
        {
            get;
            set;
        }

        public Player Owner
        {
            get;
            set;
        }

        public CountryName Id
        {
            get;
            set;
        }

        public String Name
        {
            get
            {
                return Id.ToString();
            }
        }

        public Country(CountryName name)
        {
            Id = name;
            Neighbors = new List<CountryName>();
            Armies = new List<Army>();
        }

        


    }
}

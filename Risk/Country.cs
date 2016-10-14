using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public enum CountryName
    {
        Alaska,
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
        public List<Country> Neighbors
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

        //public Continent Region
        //{
        //    get;
        //    set;
        //}

        public CountryName Name { get; set; }

        public Country(CountryName name)
        {
            Name = name;
            Neighbors = new List<Country>();
            Armies = new List<Army>();
        }


    }
}

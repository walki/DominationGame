using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{

    public enum CardType
    {
        Horse,
        Cannon,
        Soldier
    }




    public class Card
    {
        public CountryName Place { get; set; }
        public CardType Type { get; set; }
    }
}

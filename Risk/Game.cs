using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    class Game
    {
        public Board GameBoard { get; set; }
        public List<Player> Players { get; set; }
        public List<Card> Deck { get; set; }

    }
}

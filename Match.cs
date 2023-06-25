using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace candy_crush
{
    public class Match
    {
        public Player Winner { get; set; }
        Player Loser { get; set; }
        Game Game { get; set; }
    }
}

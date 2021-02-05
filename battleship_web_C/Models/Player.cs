using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace battleship_web_C.Models
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int PlayerOrder { get; set; }

        public List<Ship> Ships { get; set; }
        public List<Ship> Shots { get; set; }

        public Player()
        {
            this.Ships = new List<Ship>();
            this.Shots = new List<Ship>();
        }
    }
}

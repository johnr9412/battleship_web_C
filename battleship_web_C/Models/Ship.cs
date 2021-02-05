using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace battleship_web_C.Models
{
    public class Ship
    {
        public string ShipTitle { get; set; }
        public List<Coordinate> ShipLocation { get; set; }
        public Ship()
        {
            this.ShipLocation = new List<Coordinate>();
        }
    }
}

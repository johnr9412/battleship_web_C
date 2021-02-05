using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace battleship_web_C.Models
{
    public class Shot
    {
        public Coordinate Location { get; set; }
        public bool IsHit { get; set; }

        public Shot()
        {
        }
    }
}

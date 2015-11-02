using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public  class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Position(int x = 0, int y = 0, int z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = Z;
        }
    }
}

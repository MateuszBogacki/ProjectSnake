using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMB
{
    public class Snake
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Snake(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

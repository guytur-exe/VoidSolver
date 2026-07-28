using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Units
{
    internal record struct Position
    {
        int row;
        int column;
        int facing;

        public const int Up = 0;
        public const int Down = 1;
        public const int Left = 2;
        public const int Right = 3;

        public Position(int row, int column, int facing)
        {
            this.row = row;
            this.column = column;
            this.facing = facing;
        }

        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
            this.facing = Down;
        }
    }
}

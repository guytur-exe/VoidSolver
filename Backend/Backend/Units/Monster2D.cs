using Backend.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Units
{
    internal record struct Monster2D
    {
        private byte position; // 0|0000000 - representing: facing, position on board.

        public Monster2D(int x, int y, bool facingLeft)
        {
            position = (byte)Board14x8.GetIndex(x, y);
            position = facingLeft ? (byte)(position | (1 << 7)) : position;
        }
        public Monster2D(byte position) { this.position = position; }

        public bool FacingLeft
        {
            get { return ((position >> 7) & 1) == 1; }
            set { position = value ? (byte)(position | (1 << 7)) : (byte)(position & ~(1 << 7)); }
        }

        public bool FacingRight
        {
            get { return !FacingLeft; }
            set { FacingLeft = !value; }
        }
    }
}

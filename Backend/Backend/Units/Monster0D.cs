using Backend.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Units
{
    internal record struct Monster0D
    {
        private byte position;

        public Monster0D(int x, int y)
        {
            this.position = (byte)Board14x8.GetIndex(x, y);
        }
        public Monster0D(byte position)
        {
            this.position = position;
        }
    }
}

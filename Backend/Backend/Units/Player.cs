using Backend.Board;
using Backend.Board.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Units
{
    internal record struct Player
    {
        public byte position;
        public byte information; // 0|0|00|0000 - representing: wings(boolean), sword(boolean), facing(4 options), garbage

        public static byte Down = 0;
        public static byte Up = 1;
        public static byte Left = 2;
        public static byte Right = 3;

        public Player(int x, int y, bool wings, bool sword)
        {
            position = (byte)Board14x8.GetIndex(x, y);
            information = default;
            if (wings) information |= 1;
            if (sword) information |= 2;
            information |= (byte)(Player.Down << 2);
        }

        public bool Wings
        {
            get { return (information & 1) == 1; } // check first bit
        }

        public bool Sword
        {
            get { return (information & 2) == 2; } // check second bit
        }

        public byte Facing
        {
            get { return (byte)((information >> 2) & 3); } // return third and fourth bits
        }

    }
}

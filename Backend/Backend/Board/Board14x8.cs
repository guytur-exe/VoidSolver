using Backend.Board.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Board
{
    /// <summary>
    /// a bit board of dimentions 14x8
    /// </summary>
    internal record struct Board14x8
    {
        private ulong lower64;
        private ulong upper64;

        public Board14x8(ulong lower, ulong upper)
        {
            lower64 = lower; 
            upper64 = upper;
        }

        public static int GetIndex(int x, int y)
        {
            if (x >= 0 && x < 8 && y > 0 && y < 14)
                return 14 * y + x;
            throw new IndexOutOfRangeException();
        }

        public void SetBit(int bit)
        {
            if (bit < 64 && bit >= 0) lower64 |= (1UL << bit);
            else if (bit < 112) upper64 |= (1UL << bit);
            else throw new IndexOutOfRangeException();
        }

        public void ClearBit(int bit)
        {
            if (bit < 64 && bit >= 0) lower64 &= ~(1UL << bit);
            else if (bit < 112) upper64 &= ~(1UL << bit);
            else throw new IndexOutOfRangeException();
        }

        public readonly bool GetBit(int bit)
        {
            if (bit < 64 && bit >= 0) return (((lower64 >> bit) & 1UL) == 1UL);
            if (bit < 112) return (((upper64 >> bit) & 1UL) == 1UL);
            throw new IndexOutOfRangeException();
        }

        public readonly int CountBits()
        {
            return BitOperations.PopCount(lower64) + BitOperations.PopCount(upper64);
        }

        public static Board14x8 operator &(Board14x8 l,  Board14x8 r) => new Board14x8(l.lower64 & r.lower64, l.upper64 & r.upper64);
        public static Board14x8 operator |(Board14x8 l,  Board14x8 r) => new Board14x8(l.lower64 | r.lower64, l.upper64 | r.upper64);
        public static Board14x8 operator ^(Board14x8 l,  Board14x8 r) => new Board14x8(l.lower64 ^ r.lower64, l.upper64 ^ r.upper64);
        public static Board14x8 operator ~(Board14x8 b) => new Board14x8(~b.lower64, ~b.upper64);

    }
}

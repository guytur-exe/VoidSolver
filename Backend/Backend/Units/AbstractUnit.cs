using Backend.Board.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Units
{
    internal abstract class AbstractUnit : IUnit
    {
        public const char Z = 'Z';
        public const char Up = 'W';
        public const char Down = 'A';
        public const char Left = 'S';
        public const char Right = 'D';

        public abstract void TickAction();
        public abstract void Move(char direction);

        public abstract void Visit(BlankTile tile);
        public abstract void Visit(EmptyTile tile);
        public abstract void Visit(Stairs tile);
    }
}

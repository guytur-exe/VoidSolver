using Backend.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Board.Tiles
{
    internal class Tile : ITile
    {
        private ITile tileState;

        public void Accept(IUnit unit)
        {
            tileState.Accept(unit);
        }
    }
}

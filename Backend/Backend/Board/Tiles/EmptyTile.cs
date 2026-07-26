using Backend.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Board.Tiles
{
    internal class EmptyTile : ITile
    {
        public void Accept(IUnit unit)
        {
            throw new NotImplementedException();
        }

    }
}

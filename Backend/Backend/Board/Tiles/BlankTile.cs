using Backend.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Board.Tiles
{
    internal class BlankTile : ITile
    {
        private IUnit unit;

        public IUnit GetUnit()
        {
            return this.unit;
        }

        public void Accept(IUnit unit)
        {
            throw new NotImplementedException();
        }
    }
}

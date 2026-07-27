using Backend.Units;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Board.Tiles
{
    internal interface ITile
    {
        public void Accept(IUnit u);
    }
}

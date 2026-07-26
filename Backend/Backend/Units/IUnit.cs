using Backend.Board.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Units
{
    internal interface IUnit
    {
        public void TickAction();
        public void Move(char direction);

        public void Visit(BlankTile tile);
        public void Visit(EmptyTile tile);
        public void Visit(Stairs tile);
        
        // ...
    }
}

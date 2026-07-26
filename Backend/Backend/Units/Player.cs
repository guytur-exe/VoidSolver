using Backend.Board.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Units
{
    internal class Player : AbstractUnit
    {
        public char input;
        public char facing;
        public ITile? holding;
        public bool wings;
        public bool midair;
        public bool sword;

        public void PrepareInput(char input)
        {
            this.input = input;
        }
        public override void TickAction()
        {
            switch (input)
            {
                case Z:
                    if (!Sword())
                        Wand();
                    break;
                case Up or Down or Left or Right:
                    Move(input);
                    break;
                default:
                    throw new InvalidOperationException();
            }
                
        }
        public override void Move(char input)
        {
            throw new InvalidOperationException();
        }
        public bool Wand()
        {
            throw new InvalidOperationException();
        }
        public bool Sword()
        {
            throw new InvalidOperationException();
        }


        public override void Visit(BlankTile tile)
        {
            throw new NotImplementedException();
        }
        public override void Visit(EmptyTile tile)
        {
            throw new NotImplementedException();
        }
        public override void Visit(Stairs tile)
        {
            throw new NotImplementedException();
        }
    }
}

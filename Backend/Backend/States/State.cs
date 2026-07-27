using Backend.Board.Tiles;
using Backend.Units;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.States
{
    internal class State
    {
        private ITile[][] tiles;
        private Player player;
        private List<Monster>? monsters;
        private List<Shade>? shades;
        private List<Statue>? statues;

        private State? previus;
        private char? input;
        private bool visited;

        public State(char inp, State? prev, Player p, List<Monster> m, List<Shade> sh, List<Statue> st)
        {
            input = inp;
            previus = prev;
            player = p;
            monsters = m;
            shades = sh;
            statues = st;
            Tick();
        }

        public State(State? prev, Player p, List<Monster> m, List<Shade> sh, List<Statue> st)
        {
            input = null;
            previus = prev;
            player = p;
            monsters = m;
            shades = sh;
            statues = st;
            Tick();
        }

        public State? Prev
        {
            get { return previus; }
            set { previus = value; }
        }

        [MemberNotNull(nameof(tiles))]
        public void Tick()
        {

        }
    }
}

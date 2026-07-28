using Backend.Board;
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
    internal record struct State
    {

        private byte heldTile;
        private char? input;

        private Board14x8 blanks;
        private Board14x8 glasses;
        private Board14x8 oneTimes;
        private Board14x8 zeroTimes;
        private Board14x8 pentagrams;
        private Board14x8 buttons;
        
        private Player player;

        private Monster0D[] hands;
        private Monster0D[] polygons;
        private Monster0D[] shades;
        private Monster0D[] smiles;
        private Monster0D[] whiteGolems;
        private Monster0D[] grayGolems;
        private Monster0D[] blackGolems;

        private Monster2D[] leaches;
        private Monster2D[] bugs;

        private Monster4D[] bulls;


        private List<Statue>? statues;

        private State? previus;

        public enum Tiles
        {
            Blank,
            Glass,
            OneTime,
            ZeroTime,
            Pentagram,
            OpenStairs,
            LockedStairs,
            Button,
            Count
        }

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

        public void Tick()
        {

        }
    }
}

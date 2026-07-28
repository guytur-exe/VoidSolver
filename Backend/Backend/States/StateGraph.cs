using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.States
{
    internal class StateGraph
    {
        /// <summary>
        /// keeps generating and saving states of the graph, 
        /// graph relationships are ignored
        /// </summary>
        private State start;
        private State end;
        bool? solved = null;
        private HashSet<State> states;
        private Queue<State> queue;
        public StateGraph(State s)
        {
            start = s;
            states = new HashSet<State>();
            queue = new Queue<State>();
        }
        /// <summary>
        /// generates next states that can be derived from a certain state 
        /// from going up, down, left or right, or when pressing z.
        /// states that kill the player will be dropped
        /// </summary>
        /// <param name="s">current state to derive next states from</param>
        private void GenerateNextStates(State s)
        {

        }
        /// <summary>
        /// evaluates a path from the state 'start' to a state where the level is solved.
        /// if the level cannot be solved or the max path length is reached the search stops and doesn't find a path
        /// </summary>
        public void EvaluatePath()
        {

        }

        public LinkedList<State>? Path
        {
            get 
            {
                if (solved ?? false)
                {
                    return null;
                }
                LinkedList<State> path = new LinkedList<State>();
                State? pos = end;
                while (pos != null)
                {
                    path.AddFirst(pos);
                    pos = pos.Prev;
                }
                return path;
            }
        }

    }
}

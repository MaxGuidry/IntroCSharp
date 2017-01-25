using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightFSM.Classes
{
    class FSM<T>
    {

        //INIT->IDLE : auto/onstartup
        //IDLE->WALK : if(keydown w,a,s,d)
        //WALK->IDLE : if(keyup w,a,s,d)
        //WALK->RUN  : if(keydown shift)
        //RUN->WALK  : if(keyup shift)
        public FSM()
        {
            states = new Dictionary<string, State>();
            var v = Enum.GetValues(typeof(T));
            foreach (var e in v)
            {
                State s = new State(e as Enum);
                states.Add(s.name, s);
            }
        }

        Dictionary<string, State> states;
        State cState;
        public void ChangeState(State state)
        {
            if (isValidTransition(state))
            {
                cState.onExit();
                cState = state;
                cState.onEnter();
            }
        }
        public bool AddState(State state)
        {
            if(transitions.Count==0)
            {
                transitions.Add(state.name, new List<State>());
                return true;
            }
            else if (transitions.ContainsKey(state.name) == false)
            {
                transitions.Add(state.name, new List<State>());
                return true;
            }

            return false;

        }
        public bool AddTransition<V>(V a, V b)
        {
            //FSM fsm = new FSM();
            //State init = new State();
            //State idle = new State();
            //fsm.AddState(init);
            //fsm.AddState(idle);
            //usage would be fsm.AddTransition(init, idle)
            //access the transitions for the state
            State s = a as State;
            var tmp = transitions[s.name];
            return true;
        }
        public State GetState(T e)
        {
            string key = (e as State).name;
            return states[key];
        }
        private Dictionary<string, List<State>> transitions = new Dictionary<string, List<State>>();
        private bool isValidTransition(State to)
        {
            var validStates = transitions[cState.name];
            if (validStates == null)
                return false;
            foreach (var state in validStates)
            {
                if (state == to)
                    return true;
            }
            return false;
        }
        public bool Start()
        {
            return true;
        }

        public bool Update()
        {
            return true;
        }
    }


}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightFSM.Classes
{
    class FSM
    {
        public FSM() { }

        public Dictionary<State, List<Transition>> dict = new Dictionary<State, List<Transition>>();
        public void ChangeState(State s)
        {

        }
        enum LightState
        {
            INIT = 0,
            RED = 1,
            GREEN = 2,
            YELLOW = 3,
            EXIT = 100,
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightFSM.Classes
{
    class State
    {
        public State() { }

        public delegate void OnStartState();
        OnStartState startState;

        public void OnStart()
        {
            if (startState != null)
                startState.Invoke();

        }
        
    }
}

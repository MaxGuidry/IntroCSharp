using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightFSM.Classes;
using System.Timers;
using System.Diagnostics;
namespace TrafficLightFSM
{

    public enum LightState
    {
        INIT = 0,
        RED = 1,
        GREEN = 2,
        YELLOW = 3,
        EXIT = 900,
    }

    class Program
    {
        

        class LightBehaviour
        {
            static public void RedLightBehaviour()
            {
                Console.WriteLine("I'm at the redlight");
            }
            static public void GreenLightBehaviour()
            {


            }
            static public void YellowLightBehaviour()
            {

            }
        }

        public delegate void Handler();
        static void Main(string[] args)
        {
            //usage would be 
            FSM<LightState> trafficFSM = new FSM<LightState>();
            trafficFSM.AddState(new State(LightState.INIT));
            trafficFSM.AddState(new State(LightState.RED));
            trafficFSM.AddState(new State(LightState.GREEN));
            trafficFSM.AddState(new State(LightState.YELLOW));
            trafficFSM.AddState(new State(LightState.EXIT));
            trafficFSM.AddTransition(LightState.INIT, LightState.RED);
            trafficFSM.AddTransition(LightState.RED, LightState.GREEN);
            trafficFSM.AddTransition(LightState.GREEN, LightState.YELLOW);
            trafficFSM.AddTransition(LightState.YELLOW, LightState.RED);
            trafficFSM.GetState(LightState.RED).AddEnterFunction((Handler)LightBehaviour.RedLightBehaviour);
             trafficFSM.Start();

            while (true)
            {
                trafficFSM.Update();
            }
        }



    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatFSM.Classes;
namespace CombatFSM.Classes
{
    public class Party
    {
        public Party() { }


        public Player activePlayer;

        int currentID=0;
        public void AddPlayer(Player a)
        {
            if (players.Count == 0)
            {
                players.Add(a);
                activePlayer = players[0];
            }
            else
                players.Add(a);
            a.onEndTurn += NextPlayer;
        }


        public bool CanIncrementActivePlayer()
        {
            int i = 0;
            foreach (Player a in players)
            {
                if (i == players.Count - 1)
                {
                    activePlayer = players[0];
                    return false;
                }
                else if (a == activePlayer)
                {
                    return true;
                }
                i++;
            }
            return false;
        }


        public void NextPlayer()
        {
            if(CanIncrementActivePlayer()==false)
            {
                activePlayer = players[0];
                EndParty();
                return;
            }
            
            int i = 0;
            foreach (Player a in players)
            {
                if (a == activePlayer && i + 1 < players.Count)
                {
                    activePlayer = players[i + 1];
                    break;
                }
                else if (activePlayer == players[i] && i + 1 >= players.Count)
                {
                    activePlayer = players[0];
                }
                i++;
            }
        }

        public delegate void OnPartyEnd();

        public OnPartyEnd onPartyEnd;

        void EndParty()
        {
            if (onPartyEnd != null)
                onPartyEnd.Invoke();
        }

        private List<Player> players = new List<Player>();
    }
}

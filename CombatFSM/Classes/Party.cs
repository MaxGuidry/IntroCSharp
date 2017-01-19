using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatFSM.Classes;
using System.IO;
using System.Xml.Serialization;
namespace CombatFSM.Classes
{
    public class Party
    {
        public Party() { }

        //public Player ACTIVEPLAYER { get { return activePlayer; } set { activePlayer = value; } }
        public Player activePlayer;

        public void OnLoad()
        {
            List<Player> temp = new List<Player>();
            for (int i = 0; i < players.Count; i++)
            {
                temp.Add(players[i]);
                
            }
            for (int i = 0; i < temp.Count; i++)
            {
                AddPlayer(temp[i]);
            }
            players = temp;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Name ==activePlayer.Name)
                {
                    activePlayer = players[i];
                }
            }
        }
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
            if (CanIncrementActivePlayer() == false)
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
        [XmlIgnore]
        public OnPartyEnd onPartyEnd;

        void EndParty()
        {
            if (onPartyEnd != null)
                onPartyEnd.Invoke();
        }
       public List<Player> PLAYER { get { return players; } set { players = value; } }
        private List<Player> players = new List<Player>();
    }
}

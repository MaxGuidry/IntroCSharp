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
        public void addPlayer(Player a)
        {
            if (players.Count == 0)
            {
                players.Add(a);
                activePlayer = players[0];
            }
            else
                players.Add(a);
        }
        public bool canIncrementActivePlayer()
        {
            int i = 0;
            foreach (Player a in players)
            {
                if(i==players.Count-1)
                {
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
        public void incrementActivePlayer()
        {
            int i=0;
            foreach(Player a in players)
            {
                if(a==activePlayer)
                {
                    activePlayer=players[i+1];
                    break;
                }
                i++;
            }
        }
        private List<Player> players = new List<Player>();
    }
}

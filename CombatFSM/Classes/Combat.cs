using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatFSM.Classes;
namespace CombatFSM
{
    public class Combat
    {
        public Combat() { }
        public void incrementActiveParty()
        {
            int i = 0;
            foreach (Party a in parties)
            {
                if (a == activeParty&&i+1<parties.Count)
                {
                    activeParty = parties[i + 1];
                    
                    break;
                }
                else if(activeParty==parties[i]&&i+1>=parties.Count)
                {
                    activeParty = parties[0];
                }
                i++;
            }
        }
        public void incrementActivePlayer()
        {
            if (activeParty.canIncrementActivePlayer() == false)
            {

                incrementActiveParty();
            }
            else
                activeParty.incrementActivePlayer();
        }
        public Party activeParty;
        public void addParty(Party a)
        {
            if (parties.Count == 0)
            {
                parties.Add(a);
                activeParty = parties[0];
            }
            else
                parties.Add(a);
        }
        public void addPlayer(Player a, int party)
        {
            parties[party - 1].addPlayer(a);
        }
        private List<Party> parties = new List<Party>();
    }
}

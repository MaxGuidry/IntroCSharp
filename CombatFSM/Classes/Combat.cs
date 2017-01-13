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


       /// <summary>
       /// function to increment the active party 
       /// </summary>
        public void IncrementActiveParty()
        {
            int i = 0;
            foreach (Party a in parties)
            {
                if (a == activeParty && i + 1 < parties.Count)
                {
                    activeParty = parties[i + 1];

                    break;
                }
                else if (activeParty == parties[i] && i + 1 >= parties.Count)
                {
                    activeParty = parties[0];
                }
                i++;
            }
        }


        public void AddParty(Party a)
        {
            if (parties.Count == 0)
            {
                parties.Add(a);
                activeParty = parties[0];
            }
            else
                parties.Add(a);
            a.onPartyEnd += IncrementActiveParty;
        }



        public void AddPlayer(Player a, int party)
        {
            parties[party - 1].AddPlayer(a);
        }


        private List<Party> parties = new List<Party>();

        public Party activeParty;
    }

    


}

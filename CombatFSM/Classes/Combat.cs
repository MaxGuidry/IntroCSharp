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
        public void OnLoad()
        {
            List<Party> temp = new List<Party>();
            for(int i =0;i<parties.Count;i++)
            {
                temp.Add(parties[i]);
                temp[i].OnLoad();
            }
            for(int i=0;i<temp.Count;i++)
            {
                AddParty(temp[i]);
            }
            parties = temp;
            for (int i = 0; i < parties.Count; i++)
            {
                if (parties[i].activePlayer.Name ==activeParty.activePlayer.Name)
                {
                   activeParty = parties[i];
                }
            }
        }

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

        public List<Party> PARTY { get { return parties; } set { parties = value; } }
        private List<Party> parties = new List<Party>();

        
        public Party activeParty;
    }

    


}

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
            
        }
        public void incrementActivePlayer()
        {
            
        }
        public Party activeParty;
        public void addParty(Party a)
        {
            parties.Add(a);
        }
        private List<Party> parties= new List<Party>();
    }
}

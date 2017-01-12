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
            players.Add(a);
        }
        private List<Player> players =new List<Player>();
    }
}

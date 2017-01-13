using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatFSM.Classes;
namespace CombatFSM.Classes
{
    public class Player
    {
        public Player(string name)
        {
            m_name = name;
        }

        public delegate void OnEndTurn();
        public OnEndTurn onEndTurn;
        public void EndTurn()
        {
            if (onEndTurn != null)
                onEndTurn.Invoke();
        }
        public void Attack(Player p)
        {

        }

        public void Defend()
        {

        }
        private string m_name;
        public string Name { get { return m_name; } }

    }
}

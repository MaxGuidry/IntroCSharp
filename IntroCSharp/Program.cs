using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntroCSharp
{
    class Entity
    {
        public Entity() { }
        public Entity(int h, int att)
        {
            health = h;
            attackPower = att;
        }

        private int health;
        protected int Health
        {
            get
            {
                return health;
            }
        }
        private int attackPower;
        protected int AttackPower
        {
            get
            {
                return attackPower;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public virtual bool Attack(Entity e)
        {
            if (this.ToString() == e.ToString())
                return false;
            else
            {
                e.health -= attackPower;
                return true;
            }
        }

    }
    class Zombie : Entity
    {
        public Zombie() { }
        public Zombie(int h, int att) : base(h, att) { }

        public override bool Attack(Entity e)
        {
            return base.Attack(e);
        }

    }

    class Ninja : Entity
    {
        public Ninja() { }
        public Ninja(int h, int att) : base(h, att) { }

        public override bool Attack(Entity e)
        {
            return base.Attack(e);
        }
        public bool Defend()
        {
            return true;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Zombie z = new Zombie(100, 50);
            Ninja n = new Ninja(400, 20);
            n.Attack(z);
            z.Attack(n);
            


        }
    }

}
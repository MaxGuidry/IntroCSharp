using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;
namespace Interfaces
{
   
    public class Ninja : IDamagable, IDamager
    {
        public Ninja(int h) { health = h; }
        public void DoDamage(IDamagable d)
        {
            d.TakeDamage(10);
        }


        public void TakeDamage(int i)
        {
            health -= i;
        }
        public int Health { get { return health; } }

        private int health;
    }

    public class Zombie : IDamager, IDamagable
    {
        public Zombie(int h) { health = h; }
        public void DoDamage(IDamagable d)
        {
            d.TakeDamage(5);
        }

        public void TakeDamage(int i)
        {
            health -= i;
        }
        public int Health { get { return health; } }
        private int health;
    }

    class Program
    {

        static void Main(string[] args)
        {
            Zombie z = new Zombie(100);
            Ninja n = new Ninja(100);
            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Z)
                    z.DoDamage(n);
                else if (key == ConsoleKey.N)
                    n.DoDamage(z);
                Console.WriteLine("Zombies Health: " + z.Health);
                Console.WriteLine("Ninjas Health: " + n.Health + "\n\n");
            }
        }
    }
}

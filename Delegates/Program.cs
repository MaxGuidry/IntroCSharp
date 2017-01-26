using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Callback();
    class Program
    {

        public class Person
        {
            public void AddFunction(Delegate d)
            {
                if (onShout == null)
                {
                    onShout = d as Callback;
                    return;
                }
                onShout += d as Callback;
            }
            public void Act()
            {
                if (onShout != null)
                    onShout.Invoke();
            }
            public void RemoveFunction(Delegate d)
            {
                if (onShout == null)
                    return;
                onShout -= d as Callback;
            }
            public void RemoveAllFunctions()
            {
                onShout = null;
            }
            Callback onShout;
        }








        static void thisisdkdkdkj()
        {
            Console.WriteLine("nigger");
        }

        static void DoOtherThing()
        {
            Console.WriteLine("Other One");
        }
        static void DoThing()
        {
            Console.WriteLine("asdfasdfasdfasdfasdasdfasdf");
        }
        static void Main(string[] args)
        {
            Person p = new Person();

            Callback cb = DoThing;
            Callback[] ccc = { DoThing, DoOtherThing, thisisdkdkdkj };
            p.AddFunction(cb);
            int ct = 0;
            while (true)
            {
                ConsoleKeyInfo c = Console.ReadKey(true);
                if (c.Key == ConsoleKey.A)
                {
                    
                    
                    p.Act();
                  
                }

                if (c.Key == ConsoleKey.Spacebar)
                {
                    p.RemoveFunction(ccc[ct]);
                    ct++;
                    if (ct > 2)
                        ct = 0;
                    p.AddFunction(ccc[ct]);
                }
            }
        }
    }
}

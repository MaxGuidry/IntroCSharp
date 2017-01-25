using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gists
{
    class Program
    {
        static public char Invert(char s)
        {
            return ((s == '0') ? '1' : '0');
        }

        public class Gene
        {
            public Gene(string s)
            {
                if (s.Length != 8)
                    throw new Exception("too big or too small... must be 8 long");
                value = s;
                tail = value.Substring(4);
                head = value.Remove(4, 4);
            }
            string value;
            string tail;
            string head;
            public override string ToString()
            {
                return value;
            }
            public string Head
            {
                get
                {
                    return head;
                }
            }

            public string Tail
            {
                get
                {
                    return tail;
                }
            }
        }
        static void printEvenNumbers(ref List<int> list)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i);
                }

            }
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    list.Remove(i);
                }

            }
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
        }
        static string BinaryStringThing(string s)
        {
            Gene g = new Gene(s);

            string str = "";

            foreach(var v in g.Tail)
            {
                str += Invert(v);
            }
            str += g.Tail;
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input: "+"11110011");
            Console.WriteLine("output: " + BinaryStringThing("11110011"));
            Console.WriteLine("input: "+"00001010");
            Console.WriteLine("output: " + BinaryStringThing("00001010"));
            Console.WriteLine("input: "+"00000101");
            Console.WriteLine("output: " + BinaryStringThing("00000101"));
            Console.WriteLine("input: "+"10101100");
            Console.WriteLine("output: "+BinaryStringThing("10101100"));
            Console.Read();

        }
    }

}


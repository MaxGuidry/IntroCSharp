using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gists
{
    class Program
    {
        static void printEvenNumbers(ref List<int> list)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i);
                }
              
            }
            foreach(int num in list)
            {
                Console.WriteLine(num);
            }
            for(int i=1;i<=100;i++)
            {
                if (i % 10 == 0)
                {
                    list.Remove(i);
                }
                
            }
            foreach(int num in list)
            {
                Console.WriteLine(num);
            }
        }
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            printEvenNumbers(ref intList);

            Console.Read();
            
        }
    }
    
}


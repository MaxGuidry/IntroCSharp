using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.Clear();
                Random PCChoice = new Random();
                int rand = PCChoice.Next(49, 52);
                Console.WriteLine("Press 1 for Rock, 2 for Paper and 3 for Scissors. Press 'Q' to quit.");
                Console.Write("User Choice: ");
                ConsoleKeyInfo test = Console.ReadKey();
                int UserChoice = test.KeyChar;
                Console.WriteLine(test.Key);
                Console.Clear();
                Console.WriteLine("Press 1 for Rock, 2 for Paper and 3 for Scissors. Press 'Q' to quit.");
                Console.Write("User Choice: ");
               
                if (test.Key.ToString() == "D1")
                {
                    Console.Write("Rock\n");
                    if (rand == UserChoice)
                    {
                        Console.WriteLine("PC Chose: Rock");
                        Console.WriteLine("You Tied");
                    }
                    if (rand==50)
                    {
                        Console.WriteLine("PC Chose: Paper");
                        Console.WriteLine("You Lose!");
                    }
                    else if (rand == 51)
                    {
                        Console.WriteLine("PC Chose: Scissors");
                        Console.WriteLine("You Win!");
                    }
                }
                if (test.Key.ToString() == "D2")
                {
                    Console.Write("Paper\n");
                    if (rand == UserChoice)
                    {
                        Console.WriteLine("PC Chose: Paper");
                        Console.WriteLine("You Tied");
                    }
                    if (rand == 49)
                    {
                        Console.WriteLine("PC Chose: Rock");
                        Console.WriteLine("You Win!");
                    }
                    else if (rand == 51)
                    {
                        Console.WriteLine("PC Chose: Scissors");
                        Console.WriteLine("You Lose!");
                    }
                }
                if (test.Key.ToString() == "D3")
                {
                    Console.Write("Scissors\n");
                    if (rand == UserChoice)
                    {
                        Console.WriteLine("PC Chose: Scissors");
                        Console.WriteLine("You Tied");
                    }
                    if (rand == 49)
                    {
                        Console.WriteLine("PC Chose: Rock");
                        Console.WriteLine("You Lose!");
                    }
                    else if (rand == 50)
                    {
                        Console.WriteLine("PC Chose: Paper");
                        Console.WriteLine("You Win!");
                    }
                }
                if (test.Key == ConsoleKey.Q)
                    break;
                System.Threading.Thread.Sleep(2000);
               
               

            }
            Console.Clear();
            Console.WriteLine("Game Over!");
            Console.Read();

        }
    }
}

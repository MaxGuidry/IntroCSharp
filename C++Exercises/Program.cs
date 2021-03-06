﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exercises
{
    class Position
    {
        public Position() { }
        public Position(float X, float Y)
        {
            x = X;
            y = Y;
        }
        public float X
        {
            get
            {
                return x;
            }
        }
        public float Y
        {
            get
            {
                return y;
            }
        }
       static public Position operator +(Position p,Position current)
        {
            Position temp = new Position(0, 0);
            temp.x = current.x + p.x;
            temp.y = current.y + p.y;
            return temp;
        }
        static public Position operator -(Position current, Position p)
        {
            Position temp = new Position(0, 0);
            temp.x = current.x - p.x;
            temp.y = current.y - p.y;
            return temp;
        }
        //public static Position operator +=(Position c)
        //{
        //    Position temp = new Position(0, 0);
        //    temp = c + ;

        //    return temp;
        //}
        private float x, y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////LOOPS EXERCISE----------------------------
            //for (int i = 100; i > 0; i--)            //|
            //{                                        //|
            //    Console.Write(i);                    //|
            //    Console.Write(",");                  //|
            //}                                        //|
            //Console.Write("\n\n");                   //|
            //for (int i = 100; i >= 0; i--)           //|
            //{                                        //|
            //    Console.Write(i);                    //|
            //    Console.Write(",");                  //|
            //}                                        //|
            //Console.Write("\n\n");                   //|
            //for (int i = 99; i >= 0; i--)            //|
            //{                                        //|
            //    Console.Write(i);                    //|
            //    Console.Write(",");                  //|
            //}                                        //|
            //Console.Write("\n\n");                   //|
            //for (int i = 100; i > 0; i--)            //|
            //{                                        //|
            //    Console.Write(i);                    //|
            //    Console.Write(",");                  //|
            //}                                        //|
            //Console.Write("\n\n");                   //|
            //for (int i = 100; i >= 2; i -= 2)        //|
            //{                                        //|
            //    Console.Write(i);                    //|
            //    Console.Write(",");                  //|
            //}                                        //|
            //Console.Write("\n");                     //|
            //for (int i = 1; i <= 100; i++)           //|
            //{                                        //|
            //    if (i % 3 == 0 && i % 5 == 0)        //|
            //    {                                    //|
            //        Console.WriteLine("FizzBuzz");   //|
            //    }                                    //|
            //    else if (i % 3 == 0)                 //|
            //    {                                    //|
            //        Console.WriteLine("Fizz");       //|
            //    }                                    //|
            //    else if (i % 5 == 0)                 //|
            //    {                                    //|
            //        Console.WriteLine("Buzz");       //|
            //    }                                    //|
            //    else                                 //|
            //    {                                    //|
            //        Console.WriteLine(i);            //|
            //    }                                    //|
            //}                                        //|
            //int sum = 0;                             //|
            //for (int i = 0; i < 1000; i++)           //|
            //{                                        //|
            //    if (i % 3 == 0 || i % 5 == 0)        //|
            //    {                                    //|
            //        sum += i;                        //|
            //    }                                    //|
            //}                                        //|
            //Console.WriteLine(sum);                  //|
            //Console.Write("\n\n");                   //|
            //int j = 100;                             //|
            //while (j > 0)                            //|
            //{                                        //|
            //    Console.Write(j);                    //|
            //    Console.Write(",");                  //|
            //    j--;                                 //|
            //}                                        //|
            //Console.Write("\n\n");                   //|
            //int k = 100;                             //|
            //while (k >= 0)                           //|
            //{                                        //|
            //    Console.Write(k);                    //|
            //    Console.Write(",");                  //|
            //    k--;                                 //|
            //}                                        //|
            //int n = 99;                              //|
            //Console.Write("\n\n");                   //|
            //while (n >= 0)                           //|
            //{                                        //|
            //    Console.Write(n);                    //|
            //    Console.Write(",");                  //|
            //    n--;                                 //|
            //}                                        //|
            //int e = 100;                             //|
            //Console.Write("\n\n");                   //|
            //while (e > 0)                            //|
            //{                                        //|
            //    Console.Write(e);                    //|
            //    Console.Write(",");                  //|
            //    e--;                                 //|
            //}                                        //|
            //Console.WriteLine("\n\n");               //|
            //int fb = 1;                              //|
            //while (fb <= 100)                        //|
            //{                                        //|
            //    if (fb % 5 == 0 && fb % 5 == 0)      //|
            //    {                                    //|
            //        Console.WriteLine("FizzBuzz");   //|
            //    }                                    //|
            //    else if (fb % 3 == 0)                //|
            //    {                                    //|
            //        Console.WriteLine("Fizz");       //|
            //    }                                    //|
            //    else if (fb % 5 == 0)                //|
            //    {                                    //|
            //        Console.WriteLine("Buzz");       //|
            //    }                                    //|
            //    else                                 //|
            //    {                                    //|
            //        Console.WriteLine(fb);           //|
            //    }                                    //|
            //    fb++;                                //|
            //}                                        //|
            //int sum2 = 0;                            //|
            //int cnt = 0;                             //|
            //while (cnt < 1000)                       //|
            //{                                        //|
            //    if (cnt % 3 == 0 || cnt % 5 == 0)    //|
            //    {                                    //|
            //        sum2 += cnt;                     //|
            //    }                                    //|
            //    cnt++;                               //|
            //}                                        //|
            //Console.WriteLine(sum2);                 //|
            //------------------------------------------                  
            Position first = new Position(2, 5);
            Position second = new Position(2, 5);
            first = first + second;
            Console.WriteLine(first.X + "," + first.Y);
            first = first - second;
            Console.WriteLine(first.X + "," + first.Y);
            first += second;
            Console.WriteLine(first.X + "," + first.Y);
            Console.Read();
        }
    }
}

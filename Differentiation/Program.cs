using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Differentiation
{

    class Program
    {
        static public int convertToInt(char a)
        {
            return a - 48;
        }
        char convertToChar(int a)
        {
            return (char)(a + 48);
        }
        static public List<char> convertToEquation(string a)
        {
            char[] temp = new char[20];
            List<char> equation = new List<char>();
            int digits = 0;
            int index = 0;
            int number = 0;
            int test = 0;
            for (int i = 0; i < a.Length + 1; i++)
            {
                if (i < a.Length)
                {

                    if (convertToInt(a[i]) >= 0 && convertToInt(a[i]) <= 9)
                    {
                        digits++;
                        temp[i] = a[i];
                    }
                    else
                    {
                        test = digits;
                        for (int j = 0; j < test; j++)
                        {
                            if (digits == 1)
                                number += convertToInt(temp[index]);
                            else
                                number += (int)(convertToInt(temp[index]) * (Math.Pow(10, digits - 1)));
                            index++;
                            digits--;
                        }
                    }
                    if (a[i] == '*' || a[i] == 'x' || a[i] == '+' || a[i] == '-' || a[i] == '^')
                    {
                        if (number > 0)
                            equation.Add((char)number);
                        number = 0;
                        equation.Add(a[i]);
                        index++;
                    }
                }
                else
                {
                    
                    test = digits;
                    for (int j = 0; j < test; j++)
                    {
                        if (digits == 1)
                            number += convertToInt(temp[index]);
                        else
                            number += (int)(convertToInt(temp[index]) * (Math.Pow(10, digits - 1)));
                        index++;
                        digits--;
                    }
                }
                
                if (number > 0)
                {
                    equation.Add((char)number);
                    number = 0;
                }
            }
            
            return equation;
        }
        static public List<char> differentiate(List<char> a)
        {
            List<char> temp = new List<char>();
            
            return temp;
        }
        static void Main(string[] args)
        {

            string equation = Console.ReadLine();
           List<char> testing = convertToEquation(equation);
            foreach(char a in testing)
            {
                Console.Write(a);
            }
            Console.Read();
        }
    }
}

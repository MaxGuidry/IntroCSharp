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
        static public string convertToEquation(string a)
        {
            char[] temp = new char[10];
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
                                number += (int)(convertToInt(temp[index]) * (Math.Pow(10 , digits - 1)));
                            index++;
                            digits--;
                        }
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
                if(number>0)
                {
                    equation.Add((char)number);
                }
            }
            string temper = temp.ToString();
            return temper;
        }
        static void Main(string[] args)
        {
            
            string equation = Console.ReadLine();
            convertToEquation(equation);
            for (int i = 0; i < equation.Length; i++)
            {

            }

        }
    }
}

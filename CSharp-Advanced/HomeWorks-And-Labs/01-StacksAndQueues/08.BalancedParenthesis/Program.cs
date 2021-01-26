using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> open = new Stack<char>();

            string input = Console.ReadLine();
            bool isValid = true;

            foreach (char item in input)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    open.Push(item);
                }
                else
                {
                    bool isFirstValid = item == ')' && open.Pop() == '(';
                    bool isSecondValid = item == '{' && open.Pop() == '}';
                    bool isThirdtValid = item == ']' && open.Pop() == '[';

                    if (!isFirstValid && !isSecondValid && !isThirdtValid)
                    {
                        isValid = false;
                        Console.WriteLine("NO");
                        break;
                    }

                }
            }
            if (!open.Any())
            {
                Console.WriteLine("YES");
            }
            else if(isValid == false)
            {
                Console.WriteLine("NO");
            }
        }
    }
}

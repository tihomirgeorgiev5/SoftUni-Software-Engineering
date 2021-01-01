using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double result = 0;
           

            for (int i = 0; i < input.Length; i++)
            {
                string temp = input[i];
                char firstLetter = temp[0];
                char lastLetter = temp[temp.Length - 1];

                double number = double.Parse(temp.Substring(1, temp.Length - 2));

                int firstElementIndex = alpha.IndexOf(char.ToUpper(firstLetter));
                int secondElementIndex = alpha.IndexOf(char.ToUpper(lastLetter));

                if ((int)firstLetter >= 65 && (int)firstLetter <= 90)
                {
                    number /= firstElementIndex + 1;
                }
                else
                {
                    number *= firstElementIndex + 1;
                }

                if ((int) lastLetter >= 65 && (int)lastLetter <= 90)
                {
                    number -= secondElementIndex + 1;
                }
                else
                {
                    number += secondElementIndex + 1;
                }
                result += number;


            }
            Console.WriteLine($"{result :f2}");
        }
    }
}

﻿using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopNumber(number);

        }

        private static void PrintTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                string currentNumber = i.ToString();
                bool isOddDigit = false;
                int sumOfDigits = 0;

                foreach (var curr in currentNumber)
                {
                    int parseNumber = (int)curr;
                    if (parseNumber % 2 == 1 )
                    {
                        isOddDigit = true;
                    }

                    sumOfDigits += parseNumber;
                }
                if (sumOfDigits % 8 == 0 && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

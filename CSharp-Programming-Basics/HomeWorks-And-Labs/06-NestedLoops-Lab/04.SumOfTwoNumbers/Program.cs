﻿using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool flag = false;
            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    counter++;
                    int currentSum = num1 + num2;
                    if (currentSum == magicNum)
                    {
                        
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicNum})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
               
            }

            if (flag == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}

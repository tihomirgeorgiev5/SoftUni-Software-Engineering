﻿using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

        

            Console.WriteLine(ReturnMinNum(num1, num2, num3));
        }
        static int ReturnMinNum(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
            
        }
    }
}

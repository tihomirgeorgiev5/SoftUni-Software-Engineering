using System;

namespace _08._Divisible_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which prints all the numbers from 1 to 100,
            // which are divisible by 3.
            // You have to use a single for loop.
            // The program should not receive input.

            for (int i = 3; i < 101; i+=3)
            {
                Console.WriteLine(i);
            }

           
        }
    }
}

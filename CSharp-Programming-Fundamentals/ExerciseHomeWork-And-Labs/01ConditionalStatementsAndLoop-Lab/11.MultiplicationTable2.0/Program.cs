using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            int givenMultiplier = int.Parse(Console.ReadLine());

            if (givenMultiplier > 10)
            {
                Console.WriteLine($"{multiplier} X {givenMultiplier} = {multiplier * givenMultiplier}");
            }

            for (int i = givenMultiplier ; i <= 10; i++)
            {
                int total = multiplier * i;
                Console.WriteLine($"{multiplier} X {i} = {total}");

            }
        }
    }
}

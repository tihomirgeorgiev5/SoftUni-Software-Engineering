using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bPounds = decimal.Parse(Console.ReadLine());

           decimal dollars = bPounds * 1.31M;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}

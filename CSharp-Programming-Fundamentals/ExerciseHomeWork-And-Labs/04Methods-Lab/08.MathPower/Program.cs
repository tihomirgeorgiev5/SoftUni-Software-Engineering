using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(number,power));
        }
        static double RaiseToPower(double number, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;

        }
    }
}

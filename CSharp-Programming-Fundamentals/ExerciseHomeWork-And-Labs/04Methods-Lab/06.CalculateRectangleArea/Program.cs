using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            
            Console.WriteLine(CalculateRectArea(a, b));

        }
        static double CalculateRectArea(double a, double b)
        {
            return a * b;
        }

    }
}

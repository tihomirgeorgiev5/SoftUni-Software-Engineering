using System;
using System.Diagnostics.CodeAnalysis;

namespace Vet_parking
{
    class Program
    {
        static void Main(string[] args)
        { 
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalSum = 0;
            for (int day = 1; day <= days; day++)
            {
                double sum = 0;
                for (int hour = 1; hour <= hours; hour++)
                {
                    if (day % 2 == 0 && hour % 2 == 1)
                    {
                        sum += 2.50;
                        totalSum += 2.50;
                    }
                    else if (day % 2 == 1 && hour % 2 == 0)
                    {
                        sum += 1.25;
                        totalSum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                        totalSum += 1;
                    }
                }
                Console.WriteLine($"Day: {day} - {sum:f2} leva");
                
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");

        }
    }
}

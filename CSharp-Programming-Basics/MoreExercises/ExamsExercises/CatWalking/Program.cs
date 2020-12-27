using System;

namespace Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalking = int.Parse(Console.ReadLine());
            int walkingCounts = int.Parse(Console.ReadLine());
            int calloriesIn = int.Parse(Console.ReadLine());

            int calloriesPerMinute = 5;

            int minutesWalkingTotal = walkingCounts * minutesWalking;
            int calloriesOut = minutesWalkingTotal * calloriesPerMinute;

            if (calloriesOut >= calloriesIn * 0.5)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {calloriesOut}.");
            }
            else 
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {calloriesOut}.");
            }
        }
    }
}

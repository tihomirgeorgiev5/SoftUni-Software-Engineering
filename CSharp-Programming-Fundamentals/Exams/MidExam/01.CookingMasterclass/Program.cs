using System;

namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = float.Parse(Console.ReadLine());
            double studentsCount = float.Parse(Console.ReadLine());
            double flourPricePerPack = float.Parse(Console.ReadLine());
            double eggPrice = float.Parse(Console.ReadLine());
            double apronPrice = float.Parse(Console.ReadLine()); ;
            int flourFreeCount = 0;

            double ApronCountCount = studentsCount + (Math.Ceiling(studentsCount * 0.2));
            double eggCountTotal = 10 * studentsCount;

            for (int i = 1; i <= studentsCount; i++)
            {
                if (i % 5 == 0)
                {
                    flourFreeCount++;
                }
            }

            double flourTotalPrice = (studentsCount - flourFreeCount) * flourPricePerPack;

            double totalPrice = ((ApronCountCount * apronPrice)
                + (eggCountTotal * eggPrice)
                + flourTotalPrice);

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");

            }
            else
            {
                double neededMoney = totalPrice - budget;

                Console.WriteLine($"{neededMoney:f2}$ more needed.");
            }

        }
    }
}

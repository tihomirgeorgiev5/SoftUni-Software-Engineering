using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishersCount = int.Parse(Console.ReadLine());

            double totPrice = 0;

            if (season == "Spring")
            {
                totPrice = 3000; 
            }
            else if (season == "Summer" || season == "Autumn")
            {
                totPrice = 4200;
            }
            else if (season == "Winter")
            {
                totPrice = 2600;
            }

            if (fishersCount <= 6)
            {
                totPrice *= 0.9;
            }
            else if (fishersCount >= 7 && fishersCount <= 11)
            {
                totPrice *= 0.85;
            }
            else  
            {
                totPrice *= 0.75;
            }
            if (season == "Winter" || season == "Summer" || season == "Spring")
            {
                if (fishersCount % 2 == 0)
                {
                    totPrice  *= 0.95;
                }
            }
            double moneyLeft = budget - totPrice;
            string output = string.Empty;
            if (budget >= totPrice)
            {
                output = $"Yes! You have {moneyLeft:f2} leva left.";
            }
            else
            {
                output = $"Not enough money! You need {Math.Abs(moneyLeft):f2} leva.";
            }
            Console.WriteLine(output);





        }
    }
}

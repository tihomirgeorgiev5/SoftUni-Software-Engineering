using System;

namespace Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            int percentAdded = int.Parse(Console.ReadLine());

            if (countNights > 7)
            {
                priceNight -= priceNight * 0.05;
            }

            double totalPriceNights = countNights * priceNight;
            double added = percentAdded * 0.01 * budget;
            double totalPrice = totalPriceNights + added;

            if (totalPrice < budget)
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"Ivanovi will be left with {leftMoney:f2} leva after vacation.");
            }

            if (totalPrice > budget)
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"{neededMoney:f2} leva needed.");
            }


        }
    }
}

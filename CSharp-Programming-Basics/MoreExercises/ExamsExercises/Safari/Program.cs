using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double expenses = liters * 2.10 + 100;

            if (day == "Saturday")
            {
                expenses = 0.9 * expenses;

            }
            else if (day == "Sunday")
            {
                expenses = 0.8 * expenses;
            }

            if (budget >= expenses)
            {
                double leftMoney = budget - expenses;
                Console.WriteLine($"Safari time! Money left: {leftMoney:f2} lv. ");

            }
            else
            {
                double neededMoney = expenses - budget;

                Console.WriteLine($"Not enough money! Money needed: {neededMoney:f2} lv.");

            }

            

        }
    }
}

using System;

namespace Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string productName = Console.ReadLine();
            int countBoughtProducts = 0;
            double totalPrice = 0;

            while (productName != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());
                countBoughtProducts++;
                if (countBoughtProducts % 3 == 0)
                {
                    productPrice /= 2;
                }
                budget -= productPrice;
                totalPrice += productPrice;

                if (budget < 0)
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {Math.Abs(budget):f2} leva!");
                    break;
                }

                productName = Console.ReadLine();

            }

            if (productName == "Stop")
            {
                Console.WriteLine($"You bought {countBoughtProducts}" +
                    $" products for {totalPrice:f2} leva.");
            }

        }
    }
}

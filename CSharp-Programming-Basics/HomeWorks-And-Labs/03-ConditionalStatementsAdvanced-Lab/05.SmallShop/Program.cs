using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double pricePerProduct = 0.0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    pricePerProduct = 0.50;
                }
                else if (product == "water")
                {
                    pricePerProduct = 0.80;
                }
                else if (product == "beer")
                {
                    pricePerProduct = 1.20;
                }
                else if (product == "sweets")
                {
                    pricePerProduct = 1.45;
                }
                else
                {
                    pricePerProduct = 1.60;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    pricePerProduct = 0.40;
                }
                else if (product == "water")
                {
                    pricePerProduct = 0.70;
                }
                else if (product == "beer")
                {
                    pricePerProduct = 1.15;
                }
                else if (product == "sweets")
                {
                    pricePerProduct = 1.30;
                }
                else
                {
                    pricePerProduct = 1.50;
                }
            }
            else
            {
                if (product == "coffee")
                {
                    pricePerProduct = 0.45;
                }
                else if (product == "water")
                {
                    pricePerProduct = 0.70;
                }
                else if (product == "beer")
                {
                    pricePerProduct = 1.10;
                }
                else if (product == "sweets")
                {
                    pricePerProduct = 1.35;
                }
                else
                {
                    pricePerProduct = 1.55;
                }
            }
            double totalPrice = pricePerProduct * quantity;
            Console.WriteLine(totalPrice);


        }
    }
}

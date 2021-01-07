using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantityProduct = int.Parse(Console.ReadLine());
            CalculateTotalPrice(product, quantityProduct);

            static void CalculateTotalPrice(string name, int count)
            {
                double price = 0;
                switch (name)
                {
                    case "coffee":
                        price = 1.50 * count;
                        break;
                    case "water":
                        price = 1.00 * count;
                        break;
                    case "coke":
                        price = 1.40 * count;
                        break;
                    case "snacks":
                        price = 2.00 * count;
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"{price:f2}");


            }
        }
    }
}

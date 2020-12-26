using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            // ⦁	Първи ред – Цена за килограм зеленчуци – реално число[0.00… 1000.00]
            double priceVegKg = double.Parse(Console.ReadLine());
            //⦁	Втори ред – Цена за килограм плодове – реално число[0.00… 1000.00]
            double priceFrKg = double.Parse(Console.ReadLine());
            //⦁	Трети ред – Общо килограми на зеленчуците – цяло число[0… 1000]
            int totalVegKg = int.Parse(Console.ReadLine());
            //⦁	Четвърти ред – Общо килограми на плодовете – цяло число[0… 1000]
            int totalFrKg = int.Parse(Console.ReadLine());

            // едно евро е равно на 1.94лв)
            double euroPriceVegKg = priceVegKg / 1.94;
            double euroPriceFrKg = priceFrKg / 1.94;

            double total = (euroPriceFrKg * totalFrKg) + (euroPriceVegKg * totalVegKg);
            Console.WriteLine($"{total:f2}");

        }
    }
}

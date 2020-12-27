using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChickenMenu = int.Parse(Console.ReadLine());
            int countFishMenu = int.Parse(Console.ReadLine());
            int countVegetarianMenu = int.Parse(Console.ReadLine());

            // suma za meniutata
            double sumMenus = countChickenMenu * 10.35 + countFishMenu * 12.40 + countVegetarianMenu * 8.15;
            double dessertPrice = 0.2 * sumMenus;

            double totalSum = sumMenus + dessertPrice + 2.50;

            Console.WriteLine($"Total: {totalSum:f2}");



        }
    }
}

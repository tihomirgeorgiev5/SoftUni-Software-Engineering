using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int soldPuzzles = int.Parse(Console.ReadLine());
            int soldDolls = int.Parse(Console.ReadLine());
            int soldTeddyBears = int.Parse(Console.ReadLine());
            int soldMignions = int.Parse(Console.ReadLine());
            int soldTrucks = int.Parse(Console.ReadLine());

            double puzzlesMoney = soldPuzzles * 2.60;
            double dollsMoney = soldDolls * 3;
            double teddyBearsMoney = soldTeddyBears * 4.10;
            double mignionsMoney = soldMignions * 8.20;
            double trucksMoney = soldTrucks * 2;

            double totalMoney = puzzlesMoney + dollsMoney + teddyBearsMoney
                + mignionsMoney + trucksMoney;

            int countSoldToys = soldTrucks + soldTeddyBears + soldPuzzles
                + soldMignions + soldDolls;

            if (countSoldToys >= 50)
            {
                totalMoney = totalMoney - (totalMoney * 0.25);
            }
            totalMoney = totalMoney - (totalMoney * 0.1);

            if (totalMoney >= travelPrice)
            {
                double remainingMoney = totalMoney - travelPrice;
                Console.WriteLine($"Yes! {remainingMoney:f2} lv left.");
            }
            else 
            {
                double neededMoney = travelPrice - totalMoney;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }


        }
    }
}

using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double bedPrice = double.Parse(Console.ReadLine());
            double toiletForOneMonth = double.Parse(Console.ReadLine());

            //храна, тоалетна, играчки и посещение при ветеринар./ месец

            double foodPrice = toiletForOneMonth * 1.25;
            double toysPrice = foodPrice * 0.5;
            double vetPrice = toysPrice * 1.1;
            double unexpCosts = (toiletForOneMonth + foodPrice + toysPrice + vetPrice) * 0.05;

            double totalCosts = (toiletForOneMonth + foodPrice + toysPrice + vetPrice) * 12 + unexpCosts * 12 + bedPrice;

            Console.WriteLine($"{totalCosts:f2} lv.");
           
        }
    }
}

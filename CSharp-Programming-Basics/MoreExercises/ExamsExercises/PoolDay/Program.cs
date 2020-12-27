using System;

namespace Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            double taxEntry = double.Parse(Console.ReadLine());
            double priceSunbed = double.Parse(Console.ReadLine());
            double priceSunUmbrella = double.Parse(Console.ReadLine());

            //За всеки един човек от екипа трябва да се заплати такса вход.
            //Трябва да имате предвид, че един чадър стига за двама души. 
            //Знае се, че само 75 % от екипа искат шезлонги.
            //изчислението на броя на чадърите и шезлонгите, техният брой да се закръгли до по-голямото цяло число

            double totalPriceEntry = countPeople * taxEntry;
            double totalPeopleSunBed = Math.Ceiling(countPeople * 0.75);
            double totalPriceSunBed = totalPeopleSunBed * priceSunbed;
            double totalPeopleSunUmbrella = Math.Ceiling(countPeople * 0.5);
            double totalPriceSunUmbrella = totalPeopleSunUmbrella * priceSunUmbrella;

            double totalPrice = totalPriceEntry + totalPriceSunBed + totalPriceSunUmbrella;

            Console.WriteLine($"{totalPrice:f2} lv.");



        }
    }
}

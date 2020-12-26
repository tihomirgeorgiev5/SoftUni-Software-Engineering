using System;

namespace PetFood
{
    class Program
    {
        static void Main(string[] args)
        {
            //Еднa опаковка храна за кучета е на цена 2.50лв;
            // а всяка останала, която не е за тях струва 4лв;
            //1. Броят на кучетата - цяло число;
            //2.Броят на останалите животни - цяло число,
            //Изхоd На конзолата се отпечатва:{ крайната сума}lv

            double dogFood = 2.5;
            int otherFood = 4;

            int dog = int.Parse(Console.ReadLine());
            int other = int.Parse(Console.ReadLine());

            double priceDogFood = dog * dogFood;
            double priceOtherFood = other * otherFood;
            double razhodi = priceDogFood + priceOtherFood;

            Console.WriteLine($"{razhodi} lv.");


        }
    }
}

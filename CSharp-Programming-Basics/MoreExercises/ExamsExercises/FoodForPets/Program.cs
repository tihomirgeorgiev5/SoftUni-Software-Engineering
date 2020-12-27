using System;

namespace Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days= int.Parse(Console.ReadLine());
            double foodTotalCount = double.Parse(Console.ReadLine());

            double dogFood = 0;
            double catFood = 0;
            double biscuits = 0;

            for (int i = 1; i <= days; i++)
            {
                int dogsFoodEatPerDay = int.Parse(Console.ReadLine());
                int catsFoodEatPerDay = int.Parse(Console.ReadLine());

                dogFood += dogsFoodEatPerDay;
                catFood += catsFoodEatPerDay;

                if (i % 3 == 0)
                {
                    biscuits += (dogsFoodEatPerDay + catsFoodEatPerDay) * 0.1;
                }

            }
            double eatenFood = dogFood + catFood;
            double percentEatenFood = eatenFood / foodTotalCount * 100;
            double percentEatenFoodFromDog = dogFood / eatenFood * 100;
            double percentEatenFoodFromCat = catFood / eatenFood * 100;


            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentEatenFoodFromDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentEatenFoodFromCat:f2}% eaten from the cat.");
        }
    }
}

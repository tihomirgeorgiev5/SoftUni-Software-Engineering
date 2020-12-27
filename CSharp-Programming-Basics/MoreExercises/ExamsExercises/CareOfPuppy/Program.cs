using System;

namespace Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodDog = int.Parse(Console.ReadLine());
            int totalFood = 0;
            string command = "";
            while (true)
            {
                int eatFood = int.Parse(Console.ReadLine());
                totalFood += eatFood;

                if (command == "Adopted")
                {
                    break;
                }

            }
            int foodDogGrams = foodDog * 1000;

            if (totalFood < foodDogGrams)
            {
                int diff = foodDogGrams - totalFood;
                Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
            }
            else if (totalFood > foodDogGrams)
            {
                int givenFood = totalFood - foodDogGrams;
                Console.WriteLine($"Food is not enough. You need {givenFood} grams more.");
            }





        }
    }
}

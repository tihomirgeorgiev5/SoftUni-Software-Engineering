using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (degrees >= 10 && degrees <= 18)
            {
                if (dayTime == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (dayTime == "Afternoon" || dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }

            }
            if (degrees > 18 && degrees <= 24)
            {
                if (dayTime == "Morning" || dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (dayTime == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }


            }
            if (degrees >= 25)
            {
                if (dayTime == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (dayTime == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

        }
    }      
}

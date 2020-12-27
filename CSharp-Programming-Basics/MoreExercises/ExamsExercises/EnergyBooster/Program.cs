using System;

namespace Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string sizeSet = Console.ReadLine();
            int setsCount = int.Parse(Console.ReadLine());

            double price = 0;

            switch (sizeSet)
            {
                case "small":
                    if (fruit == "Watermelon")
                    {
                        price = 2 * 56;
                    }
                    else if (fruit == "Mango")
                    {
                        price = 2 * 36.66;
                    }
                    else if (fruit == "Pineapple")
                    {
                        price = 2 * 42.10;
                    }
                    else if (fruit == "Raspberry")
                    {
                        price = 2 * 20;
                    }
                    break;

                case "big":
                    if (fruit == "Watermelon")
                    {
                        price = 5 * 28.70;
                    }
                    else if (fruit == "Mango")
                    {
                        price = 5 * 19.60;
                    }
                    else if (fruit == "Pineapple")
                    {
                        price = 5 * 24.80;
                    }
                    else if (fruit == "Raspberry")
                    {
                        price = 5 * 15.20;
                    }
                    break;



            }

            double priceTotal = price * setsCount;


            if (priceTotal >= 400 && priceTotal <= 1000)
            {
                priceTotal *= 0.85;
            }
            else if (priceTotal > 1000)
            {
                priceTotal *= 0.5;
            }

            Console.WriteLine($"{priceTotal:f2} lv.");





        }
    }
}

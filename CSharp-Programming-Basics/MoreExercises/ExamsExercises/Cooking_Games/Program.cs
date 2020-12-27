using System;

namespace Cooking_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfContestants = int.Parse(Console.ReadLine());

            int totalSoldGoods = 0;
            double totalMoney = 0;

            for (int i = 0; i < numOfContestants; i++)
            {
                string name = Console.ReadLine();
                int numCookies = 0;
                int numWaffles = 0;
                int numOfCakes = 0;
                string input = Console.ReadLine();
                
               
                while(input != "Stop baking!")
                {
                    int num = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case "cookies":
                            numCookies += num;
                            break;
                        case "waffles":
                            numWaffles += num;
                            break;
                        case "cakes":
                            numOfCakes += num;
                            break;
                    }


                    input = Console.ReadLine();
                }
                totalSoldGoods += numCookies + numOfCakes + numWaffles;
                totalMoney += numCookies * 1.50 + numOfCakes * 7.80 + numWaffles * 2.30;

                Console.WriteLine($"{name} baked {numCookies} cookies, {numOfCakes} cakes and {numWaffles} waffles.");
            }
            Console.WriteLine($"All bakery sold: {totalSoldGoods}");
            Console.WriteLine($"Total sum for charity: {totalMoney:f2} lv.");
        }
    }
}

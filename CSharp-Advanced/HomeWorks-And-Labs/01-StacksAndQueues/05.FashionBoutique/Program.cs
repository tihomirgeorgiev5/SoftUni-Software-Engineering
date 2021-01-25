using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();

            int capacityRack = int.Parse(Console.ReadLine());

            Stack<int> allClothes = new Stack<int>(clothesInBox);
            int currentCapacityRack = capacityRack;
            int racksCount = 1;

            

            while (allClothes.Any())
            {
                int clothes = allClothes.Pop();
                currentCapacityRack -= clothes;

                if (currentCapacityRack < 0)
                {
                    racksCount++;
                    currentCapacityRack = capacityRack - clothes;
                }
            }

            Console.WriteLine(racksCount);

        }
    }
}

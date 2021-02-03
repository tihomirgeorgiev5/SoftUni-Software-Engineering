using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ").ToArray();

                string color = input[0];
                string[] clothes = input[1].Split(",").ToArray();

                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());


                   
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!dict[color].ContainsKey(clothes[j]))
                    {
                        dict[color].Add(clothes[j], 0);
                    }
                    dict[color][clothes[j]]++;
                }
            }

            string[] clothingToFind = Console.ReadLine().Split()
                .ToArray() ;

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var clothing in item.Value)
                {
                    Console.Write($"* {clothing.Key} - {clothing.Value} ");

                    if (clothing.Key == clothingToFind[1] && item.Key == clothingToFind[0])
                    {
                        Console.Write("(found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

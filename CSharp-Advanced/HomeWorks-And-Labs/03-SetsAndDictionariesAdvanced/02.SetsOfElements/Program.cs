using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToArray();

            HashSet<int> num = new HashSet<int>();
            HashSet<int> num2 = new HashSet<int>();

            int set1Count = input[0];
            int set2Count = input[1];


            for (int i = 0; i < set1Count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                num.Add(currentNum);
            }

            for (int i = 0; i < set2Count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                num2.Add(currentNum);
            }

            var intersection = num.Intersect(num2);

            foreach (var item in intersection)
            {
                Console.Write($"{item} ");
            }

          
        }
    }
}

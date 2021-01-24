using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] numToActed = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();


            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(numToActed[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            bool isFound = numbers.Contains(x);

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else if (!numbers.Any())
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }




           
        }
    }
}

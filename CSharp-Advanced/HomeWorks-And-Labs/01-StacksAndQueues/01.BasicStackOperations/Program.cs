using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ").Select(int.Parse)
                .ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];


            int[] numbToActed = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

           

            for (int i = 0; i < n; i++)
            {
                numbers.Push(numbToActed[i]);
            }

            //Console.WriteLine(numbers.Pop());
            //Console.WriteLine(numbers.Pop());
            //
            //Console.WriteLine(string.Join(", ", numbers));

            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }
            //Console.WriteLine(string.Join(", ", numbers));

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

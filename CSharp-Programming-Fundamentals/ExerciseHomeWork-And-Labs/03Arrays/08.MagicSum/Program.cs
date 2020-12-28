using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] + array[i] == sum)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                }
            }
        }
    }
}

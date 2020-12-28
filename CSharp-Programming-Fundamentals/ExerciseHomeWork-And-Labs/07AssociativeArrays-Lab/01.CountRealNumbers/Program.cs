using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToArray();
            var number = new SortedDictionary<double, int>();

            foreach (var realNum in numbers)
            {
                if (number.ContainsKey(realNum))
                {
                    number[realNum]++;
                }
                else
                {
                    number.Add(realNum, 1);
                }

            }
            foreach (var item in number)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}

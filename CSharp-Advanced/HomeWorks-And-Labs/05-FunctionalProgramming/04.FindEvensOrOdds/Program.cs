using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = range[0];
            int final = range[1];
            string criteria = Console.ReadLine();

            Func<int, int, List<int>> generateRangeOfNums =
                (s, f) =>
                {
                    List<int> nums = new List<int>();

                    for (int i = s; i < f; i++)
                    {
                        nums.Add(i);
                    }
                    return nums;

                };

            List<int> numbers = generateRangeOfNums(start, final);

            Predicate<int> predicate = n => true;

            if (criteria == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else if (criteria == "even")
            {
                predicate = n => n % 2 == 0;
            }

            Console.WriteLine(string.Join(" ", MyWhere(numbers, predicate)));

            static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
            {
                List<int> newNumbers = new List<int>();

                foreach (var currNum in numbers)
                {
                    if (predicate(currNum))
                    {
                        newNumbers.Add(currNum);
                    }

                }
                return newNumbers;

            }
        }
    }
}

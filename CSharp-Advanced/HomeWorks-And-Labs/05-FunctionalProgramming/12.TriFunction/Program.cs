using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int> getAsciiSum = p => p.Select(c => (int)c).Sum();

            Func<List<string>, int, Func<string, int>, string> nameFunc = (people, n, func) => people.FirstOrDefault(p => func(p) >= n);

            string res = nameFunc(people, n, getAsciiSum);

            Console.WriteLine(res);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> knights = names.
                Select(name => $"Sir {name}").ToList();

            Action<List<string>> printNames =
                n => Console.WriteLine(string.Join(Environment.NewLine, n));
            printNames(knights);

        }
        static void PrintNamesMethod(List<string> names)
        {
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> newLine = names.Select(name => $"{name}").ToList();

            Action<List<string>> printNames =
                n => Console.WriteLine(string.Join(Environment.NewLine, n));

            printNames(newLine);
        }
    }

}

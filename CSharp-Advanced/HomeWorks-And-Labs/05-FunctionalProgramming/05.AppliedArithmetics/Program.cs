using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            Func<int, int> mathFunctions = num => num;
            Action<List<int>> print =
                nums => Console.WriteLine(string.Join(" ",nums));

            while (command != "end")
            {
                if (command == "add")
                {
                    mathFunctions = num => num + 1;
                    numbers = numbers.Select(mathFunctions).ToList();
                }
                else if (command == "multiply")
                {
                    mathFunctions = num => num * 2;
                    numbers = numbers.Select(mathFunctions).ToList();
                }
                else if (command == "subtract")
                {
                    mathFunctions = num => num - 1;
                    numbers = numbers.Select(mathFunctions).ToList();
                }
                else if (command == "print")
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }

        }
    }
}

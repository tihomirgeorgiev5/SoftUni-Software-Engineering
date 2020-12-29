using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"\!([A-Za-z]{3,})\!:\[([A-Za-z]{8,})\]";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {

                    string command = match.Groups[1].Value;
                    string message = match.Groups[2].Value;
                    int[] result =
                        message.Select(x => (int)x).ToArray();
                    Console.WriteLine($"{command}: {string.Join(" ", result)}");

                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}

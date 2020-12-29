using System;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOutputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOutputs; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"\|([A-Z]{4,})\|:\#([A-Za-z]+ [A-Za-z]+)\#";

                Match match =
                    Regex.Match(input, pattern);

                if (match.Success)
                {
                    string bossName = match.Groups[1].Value;
                    string title = match.Groups[2].Value;
                    int lengthName = bossName.Length;
                    int armour = title.Length;

                    Console.WriteLine($"{bossName}, The {title}");
                    Console.WriteLine($">> Strength: {lengthName}");
                    Console.WriteLine($">> Armour: {armour}");

                }
                else
                {
                    Console.WriteLine("Access denied!");

                }
                

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes =
                   new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "End")
                {
                    break;
                }
                string[] command = input.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);

                string action = command[0];
                string heroName = command[1];

                switch (action)
                {
                    case "Enroll":
                        if (!heroes.ContainsKey(heroName))
                        {
                            heroes.Add(heroName, new List<string>());
                            
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }
                        break;
                    case "Learn":
                        string spellName = command[2];
                        if (!heroes.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else
                        {
                            if (!heroes[heroName].Contains(spellName))
                            {
                                heroes[heroName].Add(spellName);
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} has already learnt {spellName}.");
                            }
                            
                        }
                        break;
                    case "Unlearn":
                        string spellName2 = command[2];
                       
                        if (!heroes.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else if (!heroes[heroName].Contains(spellName2))
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName2}.");
                        }
                        else
                        {
                            heroes[heroName].Remove(spellName2);
                        }
                        
                       
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();


            }

            Console.WriteLine("Heroes:");

            var sortedCollection = heroes
                .OrderByDescending(s => s.Value.Count)
                .ThenBy(h => h.Key);

            foreach (var (heroname,spellname) in sortedCollection)
            {
                Console.WriteLine($"== {heroname}: {string.Join(", ", spellname)}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> towns =
                new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();
            while (command != "Sail")
            {
                string[] cities = command.Split("||", StringSplitOptions.RemoveEmptyEntries);
                
                string city = cities[0];
                int population = int.Parse(cities[1]);
                int gold = int.Parse(cities[2]);
                if (towns.ContainsKey(city))
                {
                    towns[city]["population"] += population;    
                    towns[city]["gold"] += gold;    
                }
                else
                {
                    towns.Add(city, new Dictionary<string, int>()
                    {
                        { "population", population},
                        { "gold", gold}
                    });
                        
                }
                    
                
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (true)
            {
                if (command == "End")
                {
                    break;
                }
                string[] commandArg = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArg[0];
                string town = commandArg[1];

                switch (action)
                {
                    case "Plunder":
                        int people = int.Parse(commandArg[2]);
                        int gold = int.Parse(commandArg[3]);
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        towns[town]["population"] -= people;
                        towns[town]["gold"] -= gold;

                        if (towns[town]["population"] <= 0
                            || towns[town]["gold"] <= 0)
                        {
                            towns.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }

                        break;
                    case "Prosper":
                        int goldProsper = int.Parse(commandArg[2]);
                        if (goldProsper < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            break;
                        }
                        else
                        {
                            towns[town]["gold"] += goldProsper;
                            Console.WriteLine($"{goldProsper} gold added to the city treasury. {town} now has {towns[town]["gold"]} gold.");

                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            if (towns.Count < 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                towns = towns
                    .OrderByDescending(x => x.Value["gold"])
                    .ThenBy(y => y.Key)
                    .ToDictionary(k => k.Key, v => v.Value);
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");


                foreach (var city in towns)
                {
                    int population = city.Value["population"];
                    int gold = city.Value["gold"];
                    Console.WriteLine($"{city.Key} -> Population: {population} citizens, Gold: {gold} kg");
                }

            }


        }
    }
}

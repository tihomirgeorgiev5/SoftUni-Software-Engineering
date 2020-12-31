using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> cars
                = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                var carName = carInfo[0];
                var mileage = int.Parse(carInfo[1]);
                var fuel = int.Parse(carInfo[2]);

                cars.Add(carName, new Dictionary<string, int>()
                {
                    {"mileage", mileage},
                    {"fuel", fuel }
                });

            }
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "Stop")
                {
                    break;
                }

                var tokens = command.Split(" : ",
                    StringSplitOptions.RemoveEmptyEntries);
                var action = tokens[0];
                var modell = tokens[1];

                switch (action)
                {
                    case "Drive":
                        var distance = int.Parse(tokens[2]);
                        var fuel = int.Parse(tokens[3]);
                        var carFuel = cars[modell]["fuel"];

                        if (fuel > carFuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");

                        }
                        else
                        {
                            cars[modell]["mileage"] += distance;
                            cars[modell]["fuel"] -= fuel;
                            Console.WriteLine($"{modell} driven for {distance} kilometers." +
                                $" {fuel} liters of fuel consumed.");
                        }
                        if (cars[modell]["mileage"] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {modell}!");
                            cars.Remove(modell);
                        }

                        break;
                    case "Refuel":
                        var fuelToAdd = int.Parse(tokens[2]);
                        int currentFuel = cars[modell]["fuel"];

                        if (fuelToAdd + currentFuel > 75)
                        {
                            fuelToAdd = 75 - currentFuel;
                        }
                        cars[modell]["fuel"] += fuelToAdd;
                        break;
                    case "Revert":
                        var kilometers = int.Parse(tokens[2]);
                        cars[modell]["mileage"] -= kilometers;

                        if (cars[modell]["mileage"] < 10000)
                        {
                            cars[modell]["mileage"] = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{modell} mileage decreased by {kilometers} kilometers");

                        }
                        break;
                    default:
                        break;
                }



                command = Console.ReadLine();
            }

            var ordered = cars.OrderByDescending
                (x => x.Value["mileage"]).ThenBy(x => x.Key);

            foreach (var car in ordered)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value["mileage"]} kms, Fuel in the tank: {car.Value["fuel"]} lt.");

            }
                
        }
    }
}

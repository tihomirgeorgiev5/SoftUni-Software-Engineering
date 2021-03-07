﻿using System;
using System.Globalization;
using System.Threading;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

            var pizzaName = Console.ReadLine().Split()[1];

            var doughData = Console.ReadLine().Split();

            var flourType = doughData[1];
            var bakingTechnique = doughData[2];
            var weight = int.Parse(doughData[3]);

            try
            {
                var dough = new Dough(flourType, bakingTechnique, weight);
                var pizza = new Pizza(pizzaName, dough);

                var line = Console.ReadLine();

                while (line != "END")
                {
                    line = Console.ReadLine();

                    

                    var parts = line.Split();

                    var toppingName = parts[1];
                    var toppingWeight = int.Parse(parts[2]);

                    var topping = new Topping(toppingName, toppingWeight);

                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
                
            }
            

        }
    }
}
 
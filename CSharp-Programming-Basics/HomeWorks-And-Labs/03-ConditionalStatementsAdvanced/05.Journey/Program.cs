using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double totprice = 0;
            string destination = string.Empty;
            if (budget <= 100 )
            {
                 destination = "Bulgaria";
                if (season == "summer")
                {
                    totprice = budget * 0.3;
                }
                else if (season == "winter")
                {
                    totprice = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    totprice = budget * 0.4;
                }
                else if (season == "winter")
                {
                    totprice = budget * 0.8;
                }
                
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                 totprice = budget * 0.9;
            }
            string typeVacation = string.Empty;

            if (destination == "Europe")
            {
                if (season == "summer" || season == "winter")
                {
                    typeVacation = "Hotel";
                }
            }
            else if (season == "summer")
            {
                typeVacation = "Camp";
            }
            else if (season == "winter")
            {
                typeVacation = "Hotel";
            }
            

            Console.WriteLine($"Somewhere in {destination:f2}");
            Console.WriteLine($"{typeVacation} - {totprice:f2}");



        }
    }
}

using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationTime = Console.ReadLine();
            int nightToStay = int.Parse(Console.ReadLine());

            double totPriceForStudio = 0;
            double totPriceForApp = 0;

            if (vacationTime == "May" || vacationTime == "October")
            {
                totPriceForStudio = nightToStay * 50;
                totPriceForApp = nightToStay * 65;
                if (nightToStay > 7 && nightToStay <= 14)
                {
                    totPriceForStudio *= 0.95;
                }
                else if (nightToStay > 14)
                {
                    totPriceForStudio *= 0.70;
                }
            }
            else if (vacationTime == "June" || vacationTime == "September")
            {
                totPriceForStudio = nightToStay * 75.20;
                totPriceForApp = nightToStay * 68.70;
                if (nightToStay > 14)
                {
                    totPriceForStudio *= 0.8;
                }
            }
            else if (vacationTime == "July" || vacationTime == "August")
            {
                totPriceForStudio = nightToStay * 76;
                totPriceForApp = nightToStay * 77;

            }
            if (nightToStay > 14)
            {
                totPriceForApp *= 0.9;
            }

            Console.WriteLine($"Apartment: {totPriceForApp:f2} lv.");
            Console.WriteLine($"Studio: {totPriceForStudio:f2} lv.");
        }
    }
}

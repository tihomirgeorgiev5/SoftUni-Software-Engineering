using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaggageUp20 = double.Parse(Console.ReadLine());
            double baggageWeight = double.Parse(Console.ReadLine());
            int daysToTravel = int.Parse(Console.ReadLine());
            int baggageCount = int.Parse(Console.ReadLine());

            double priceBaggage = 0;
            if (baggageWeight < 10)
            {
                priceBaggage = priceBaggageUp20 * 0.2;
            }
            else if (baggageWeight >= 10 && baggageWeight <= 20)
            {
                priceBaggage = priceBaggageUp20 * 0.5;
            }
            else if (baggageWeight > 20)
            {
                priceBaggage = priceBaggageUp20;
            }

            if (daysToTravel > 30)
            {
                priceBaggage = priceBaggage + priceBaggage * 0.1;
            }
            else if (daysToTravel >= 7 && daysToTravel <= 30)
            {
                priceBaggage = priceBaggage + priceBaggage * 0.15;
            }
            else if (daysToTravel < 7)
            {
                priceBaggage = priceBaggage + priceBaggage * 0.4;
            }

            double priceBaggageTotal = priceBaggage * baggageCount;

            Console.WriteLine($" The total price of bags is: {priceBaggageTotal:f2} lv. ");



        }
    }
}

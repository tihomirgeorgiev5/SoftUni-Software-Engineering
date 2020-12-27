using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPoly = int.Parse(Console.ReadLine());
            int volumePaint = int.Parse(Console.ReadLine());
            int countThinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double pricePoly = (countPoly + 2) * 1.50;
            double totalVolumePaint = volumePaint + volumePaint * 0.1;
            double pricePaint = totalVolumePaint * 14.5;
            double priceThinner = countThinner * 5;
            double priceWorkersForOneHour = (pricePoly + pricePaint + priceThinner + 0.40) * 0.3;
            double priceWorkers = priceWorkersForOneHour * hours;
            double totalPrice = priceWorkers + pricePaint + pricePoly + priceThinner + 0.40;

            Console.WriteLine($"Total expenses: {totalPrice:f2} lv.");



            //За всеки случай, към необходимите материали,
            //Румен иска да добави още 10 % от количеството боя и
            //2 кв.м.найлон, разбира се и
            //0.40 лв.за торбички, а 
            //сумата, която се заплаща на майсторите за 1 час работа, е равна на 30 % от сбора на всички разходи за материали



        }
    }
}

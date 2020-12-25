using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {

            double cenaQgodi = double.Parse(Console.ReadLine());
            double countBananas = double.Parse(Console.ReadLine()); 
            double countOrange = double.Parse(Console.ReadLine());
            double countBerries = double.Parse(Console.ReadLine());
            double countQgodi = double.Parse(Console.ReadLine());

            //цената на малините е на половина по - ниска от тази на ягодите;
            double cenaMalini = cenaQgodi * 0.5;
            //цената на портокалите е с 40 % по - ниска от цената на малините;
            double cenaOrange = cenaMalini - (cenaMalini * 0.4);
            //ената на бананите е с 80 % по - ниска от цената на малините.
            double cenaBananas = cenaMalini - (cenaMalini * 0.8);

            double obshtaCenaQgodi = cenaQgodi * countQgodi;
            double obshtaCenaBananas = cenaBananas * countBananas;
            double obshtaCenaOrange = cenaOrange * countOrange;
            double obshtaCenaBerries = cenaMalini * countBerries;

            double total = obshtaCenaBananas + obshtaCenaBerries + obshtaCenaOrange +
                obshtaCenaQgodi;

            Console.WriteLine($"{total:f2}");


        }
    }
}

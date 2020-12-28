using System;

namespace _02._Cat_Shirt
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeSleeve = double.Parse(Console.ReadLine());
            double sizeFrontPart = double.Parse(Console.ReadLine());
            string typeFabric = Console.ReadLine();
            string tie = Console.ReadLine();

            

            double totalSize = sizeSleeve * 2 + sizeFrontPart * 2;
            double totalSizeWithPercent = totalSize * 1.1;
            double totalSizeWithPercentInM = totalSizeWithPercent / 100;

            switch (typeFabric)
            {
                case "Linen":
                    totalSizeWithPercentInM *= 15;
                    break;
                case "Cotton":
                    totalSizeWithPercentInM *= 12;
                    break;
                case "Denim":
                    totalSizeWithPercentInM *= 20;
                    break;
                case "Twill":
                    totalSizeWithPercentInM *= 16;
                    break;
                case "Flannel":
                    totalSizeWithPercentInM *= 11;
                    break;
               
            }
           

           

            double totalsizeWithPercentAndService = totalSizeWithPercentInM  + 10;

            if (tie == "Yes")
            {
                totalsizeWithPercentAndService *= 1.2;
            }

            Console.WriteLine($"The price of the shirt is: {totalsizeWithPercentAndService:f2}lv.");


        }
    }
}

using System;

namespace Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string type = Console.ReadLine();
            string hasInternet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double priceContract = 0;

            if (years == "one")
            {
                switch (type)
                {
                    case "Small":
                        priceContract = 9.98;
                        break;
                    case "Middle":
                        priceContract = 18.99;
                        break;
                    case "Large":
                        priceContract = 25.98;
                        break;
                    case "ExtraLarge":
                        priceContract = 35.99;
                        break;
                }
            }
            else if (years == "two")
            {
                switch (type)
                {
                    case "Small":
                        priceContract = 8.58;
                        break;
                    case "Middle":
                        priceContract = 17.09;
                        break;
                    case "Large":
                        priceContract = 23.59;
                        break;
                    case "ExtraLarge":
                        priceContract = 31.79;
                        break;
                }

            }

            if (hasInternet == "yes")
            {
                if (priceContract <= 10)
                {
                    priceContract += 5.50;
                }
                else if (priceContract <= 30 && priceContract > 10)
                {
                    priceContract += 4.35;
                }
                else
                {
                    priceContract += 3.85;
                }

            }
            if (years == "two")
            {
                priceContract -= priceContract * 0.0375;
            }

            double totalSum = months * priceContract;
            Console.WriteLine($"{totalSum:f2} lv.");



        }
    }
}

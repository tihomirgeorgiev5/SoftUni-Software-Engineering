using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogramCounts = int.Parse(Console.ReadLine());
            string dogramType = Console.ReadLine();
            string delivery = Console.ReadLine();

            double dogramPrice = 0;
            switch (dogramType)
            {
                case "90X130":
                    if (dogramCounts > 30 && dogramCounts <= 60)
                    {
                        dogramPrice = 0.95 * 110;
                    }
                    else if (dogramCounts > 60)
                    {
                        dogramPrice = 0.92 * 110;
                    }
                    else if (dogramCounts <= 30)
                    {
                        dogramPrice = 110;
                    }
                    break;
                case "100X150":
                    if (dogramCounts > 40 && dogramCounts <= 80)
                    {
                        dogramPrice = 0.94 * 140;
                    }
                    else if (dogramCounts > 80)
                    {
                        dogramPrice = 0.9 * 140;
                    }
                    else if (dogramCounts <= 40)
                    {
                        dogramPrice = 140;
                    }
                    break;
                case "130X180":
                    if (dogramCounts > 20 && dogramCounts <= 50)
                    {
                        dogramPrice = 0.93 * 190;
                    }
                    else if (dogramCounts > 50)
                    {
                        dogramPrice = 0.88 * 190;
                    }
                    else if (dogramCounts <= 20)
                    {
                        dogramPrice = 190;
                    }
                    break;
                case "200X300":
                    if (dogramCounts > 25 && dogramCounts <= 50)
                    {
                        dogramPrice = 0.91 * 250;
                    }
                    else if (dogramCounts > 50)
                    {
                        dogramPrice = 0.86 * 250;
                    }
                    else if (dogramCounts <= 25)
                    {
                        dogramPrice = 250;
                    }
                    break;

            }

            double totalPrice = dogramPrice * dogramCounts;

            if (delivery == "With delivery")
            {
                totalPrice += 60;
            }

            if (dogramCounts > 99)
            {
                totalPrice *= 0.96;
            }
            if (dogramCounts < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                Console.WriteLine($"{totalPrice:f2} BGN");
            }

        }
    }
}

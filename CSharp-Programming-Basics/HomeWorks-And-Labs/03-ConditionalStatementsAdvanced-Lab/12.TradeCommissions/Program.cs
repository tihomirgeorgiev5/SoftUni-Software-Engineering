using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sellVolume = double.Parse(Console.ReadLine());

            double commisionPercentage = 0.000;
            if (town == "Sofia")
            {
                if (sellVolume >= 0 && sellVolume <= 500)
                {
                    commisionPercentage = 0.05;
                }
                else if (sellVolume >= 500 && sellVolume <= 1000)
                {
                    commisionPercentage = 0.07;
                }
                else if (sellVolume >= 1000 && sellVolume <= 10000)
                {
                    commisionPercentage = 0.08;
                }
                else 
                {
                    commisionPercentage = 0.12;
                }
            }
            else if (town == "Plovdiv")
            {
                if (sellVolume >= 0 && sellVolume <= 500)
                {
                    commisionPercentage = 0.055;
                }
                else if (sellVolume >= 500 && sellVolume <= 1000)
                {
                    commisionPercentage = 0.08;
                }
                else if (sellVolume >= 1000 && sellVolume <= 10000)
                {
                    commisionPercentage = 0.12;
                }
                else  
                {
                    commisionPercentage = 0.145;
                }
            }
            else if (town == "Varna")
            {
                if (sellVolume >= 0 && sellVolume <= 500)
                {
                    commisionPercentage = 0.045;
                }
                else if (sellVolume >= 500 && sellVolume <= 1000)
                {
                    commisionPercentage = 0.075;
                }
                else if (sellVolume >= 1000 && sellVolume <= 10000)
                {
                    commisionPercentage = 0.10;
                }
                else  
                {
                    commisionPercentage = 0.13;
                }
            }
            if (town == "Plovdiv" || town == "Sofia" || town == "Varna")
            {
                if (sellVolume >= 0)
                {
                    double comission = commisionPercentage * sellVolume;
                    Console.WriteLine($"{comission:f2}");
                }
                else if (sellVolume < 0)
                {
                    Console.WriteLine("error");
                }

            }
            else 
            {
                Console.WriteLine("error");
            }
            
            
            
            


        }
    }
}

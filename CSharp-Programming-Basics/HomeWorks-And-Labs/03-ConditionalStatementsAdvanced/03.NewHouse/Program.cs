using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double totPrice = 0;

            if (flowerType == "Roses")
            {
                totPrice = flowerCount * 5;
                if (flowerCount > 80)
                {
                    totPrice *= 0.9;
                }
            }
            else if (flowerType == "Dahlias")
            {
                totPrice = flowerCount * 3.80;
                if (flowerCount > 90)
                {
                    totPrice *= 0.85;
                }

            }
            else if (flowerType == "Tulips")
            {
                totPrice = flowerCount * 2.80;
                if (flowerCount > 80)
                {
                    totPrice *= 0.85;
                }

            }
            else if (flowerType == "Narcissus")
            {
                totPrice = flowerCount * 3;
                if (flowerCount < 120)
                {
                    totPrice *= 1.15;
                }

            }
            else if (flowerType == "Gladiolus")
            {
                totPrice = flowerCount * 2.50;
                if (flowerCount < 80)
                {
                    totPrice *= 1.20;
                }
                
            }
            double moneyLeft = budjet - totPrice;
            string output = string.Empty;

            if (totPrice <= budjet)
            {
                output = $"Hey, you have a great garden with {flowerCount} {flowerType} and {moneyLeft:f2} leva left.";

            }
            else
            {
                output = $"Not enough money, you need {Math.Abs(moneyLeft):f2} leva more.";
            }

            Console.WriteLine(output);
             
        }
    }
}

using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            double p4 = 0.00;
            double p5 = 0.00;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200)
                {
                    p1++;
                }
                else if (currentNumber >= 200 && currentNumber <= 399)
                {
                    p2++;
                }
                else if (currentNumber >= 400 && currentNumber <= 599)
                {
                    p3++;
                }
                else if (currentNumber >= 600 && currentNumber <= 799)
                {
                    p4++;
                }
                else if (currentNumber >= 800)
                {
                    p5++; 
                }

            }

            double p1Result = p1 / n * 100;
            double p2Result = p2 / n * 100;
            double p3Result = p3 / n * 100;
            double p4Result = p4 / n * 100;
            double p5Result = p5 / n * 100;

            Console.WriteLine($"{p1Result:f2}%");
            Console.WriteLine($"{p2Result:f2}%");
            Console.WriteLine($"{p3Result:f2}%");
            Console.WriteLine($"{p4Result:f2}%");
            Console.WriteLine($"{p5Result:f2}%");




        }
    }
}

using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //⦁	Първи ред: число за преобразуване - реално число
            double number = double.Parse(Console.ReadLine());
            // ⦁	Втори ред: входна мерна единица - текст
            string inputMetric = Console.ReadLine();
            //⦁	Трети ред: изходна мерна единица(за резултата) - текст
            string outputMetric = Console.ReadLine();

            double result = 0;

            if (inputMetric == "mm" && outputMetric == "cm")
            {
                result = number / 10.0;
            }
            else if (inputMetric == "mm" && outputMetric == "m")
            {
                result = number / 1000.0;
            }
            else if (inputMetric == "m" && outputMetric == "mm")
            {
                result = number * 1000.0;
            }
            else if (inputMetric == "m" && outputMetric == "cm")
            {
                result = number * 100.0;
            }
            else if (inputMetric == "cm" && outputMetric == "m")
            {
                result = number / 100.0;
            }
            else if (inputMetric == "cm" && outputMetric == "mm")
            {
                result = number * 10.0;
            }
            Console.WriteLine($"{result:f3}");

        }
    }
}

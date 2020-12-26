using System;

namespace _03._Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //градуси по скалата на Целзий(°C)
            double gradCelsius = double.Parse(Console.ReadLine());
            double convertToFahrenheit = (gradCelsius * 1.8) + 32;
            Console.WriteLine($"{convertToFahrenheit:f2}");
            //(gradCelsius * 1.8) 
            //Example: (30°C x 1.8) + 32 = 86°F
        }
    }
}

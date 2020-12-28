using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distInMeters = int.Parse(Console.ReadLine());

            decimal distInKm = distInMeters  / 1000.0M;
           

            Console.WriteLine($"{distInKm:F2}");
        }
    }
}

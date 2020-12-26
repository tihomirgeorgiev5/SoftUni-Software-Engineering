using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //	Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //	Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //	Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeIn1Sec = double.Parse(Console.ReadLine());

            double countTime = distance * timeIn1Sec;
            double timeResistanceWater = (Math.Floor(distance / 15)) * 12.5;
            double totalTime = countTime + timeResistanceWater;

            double timeRest = totalTime - record;


            if (totalTime < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {timeRest:f2} seconds slower.");

            }

        }
    }
}

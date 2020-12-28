using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numOfBalls = byte.Parse(Console.ReadLine());
            
            BigInteger snowBallHigh = int.MinValue;
            short bigSnow = 0;
            short bigTime = 0;
            short bigQuality = 0;

            for (int i = 0; i < numOfBalls; i++)
            {
                short snowallSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowallSnow / snowballTime), snowballQuality);

                if(snowballValue > snowBallHigh)
                {
                    snowBallHigh = snowballValue;
                    bigSnow = snowallSnow;
                    bigTime = snowballTime;
                    bigQuality = snowballQuality;
                }


            }
            Console.WriteLine($"{bigSnow} : {bigTime} = {snowBallHigh} ({bigQuality})");

        }
    }
}

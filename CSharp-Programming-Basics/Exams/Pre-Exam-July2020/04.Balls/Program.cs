using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());

            int colorRed = 0;
            int colorOrange = 0;
            int colorYellow = 0;
            int colorWhite = 0;
            int colorBlack = 0;
            int colorOthers = 0;
            int points = 0;

            for (int i = 1; i <= balls; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    colorRed++;
                    points += 5;
                }
                else if (color == "orange")
                {
                    colorOrange++;
                    points += 10;
                }
                else if (color == "yellow")
                {
                    colorYellow++;
                    points += 15;
                }
                else if (color == "white")
                {
                    colorWhite++;
                    points += 20;
                }
                else if (color == "black")
                {
                    colorBlack++;
                    points /= 2;
                }
                else if (color == "pink")
                {
                    colorOthers++;
                    points *= 1;
                }
                else 
                {
                    colorOthers++;
                    points *= 1;

                }

            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {colorRed}");
            Console.WriteLine($"Points from orange balls: {colorOrange}");
            Console.WriteLine($"Points from yellow balls: {colorYellow}");
            Console.WriteLine($"Points from white balls: {colorWhite}");
            Console.WriteLine($"Other colors picked: {colorOthers}");
            Console.WriteLine($"Divides from black balls: {colorBlack}");


        }
    }
}

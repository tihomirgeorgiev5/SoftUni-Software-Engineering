using System;

namespace cruiseGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();
            int gamesCount = int.Parse(Console.ReadLine());

           

            int countVolleyball = 0;
            double pointsVolleyball = 0;

            int countTennis = 0;
            double pointsTennis = 0;

            int countBadminton = 0;
            double pointsBadminton = 0;

            for (int i = 1; i <= gamesCount; i++)
            {
                string nameGame = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());
                

                if (nameGame == "volleyball")
                {
                    countVolleyball++;
                    double currentPoints = points + 0.07 * points;
                    pointsVolleyball += currentPoints;
                }
                else if (nameGame == "tennis")
                {
                    countTennis++;
                    double currentPoints = points + 0.05 * points;
                    pointsTennis += currentPoints;
                }
                else if (nameGame == "badminton")
                {
                    countBadminton++;
                    double currentPoints = points + 0.02 * points;
                    pointsBadminton += currentPoints;
                }


            }

            double averageVolleyball = pointsVolleyball / countVolleyball;
            double averageTennis = pointsTennis / countTennis;
            double averageBadminton = pointsBadminton / countBadminton;

            double totalPoints = Math.Floor(pointsVolleyball + pointsTennis + pointsBadminton);

            if (averageVolleyball >= 75 && averageTennis >= 75 && averageBadminton >= 75)
            {
                Console.WriteLine($"Congratulations, {namePlayer}! You won the cruise games with {totalPoints} points");
            }
            else
            {
                Console.WriteLine($"Sorry, {namePlayer}, you lost, Your points are only {totalPoints}");
            }



        }
    }
}

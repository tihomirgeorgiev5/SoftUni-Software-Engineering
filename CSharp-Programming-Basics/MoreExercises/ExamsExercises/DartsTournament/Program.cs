using System;

namespace DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            int count = 0;
            while (points > 0)


            {
                string section = Console.ReadLine();
                count++;
                

                if (section == "number section")
                {
                    int sectionNumber = int.Parse(Console.ReadLine());
                    points -= sectionNumber;
                }
                else if (section == "double ring")
                {
                    int sectionNumber = int.Parse(Console.ReadLine());
                    points -= sectionNumber * 2;
                }
                else if (section == "triple ring")
                {
                    int sectionNumber = int.Parse(Console.ReadLine());
                    points -= sectionNumber * 3;
                }
                else if (section == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game in {count} moves!");
                    break;
                }

                if (points < 0) 
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(points)}.");
                    break;
                }
            }
            if (points == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {count} moves!");
            }

        }
    }
}

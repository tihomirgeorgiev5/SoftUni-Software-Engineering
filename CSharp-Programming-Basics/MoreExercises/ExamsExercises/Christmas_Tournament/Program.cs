using System;

namespace Christmas_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double charityMoney = 0;
            int winCounts = 0;
            int loseCounts = 0;
            int winDays = 0;
            int loseDays = 0;

            for (int i = 1; i <= days; i++)
            {
                while (input != "Finish")
                {
                    string sport = Console.ReadLine();
                    if (input == "win")
                    {
                        charityMoney+= 20;
                        winCounts++;

                    }
                    if (input == "lose")
                    {
                        loseCounts++;

                    }
                    



                    input = Console.ReadLine();
                    if (input == "Finish")
                    {
                        break;
                    }
                }

                if (winCounts > loseCounts)
                {
                    charityMoney += charityMoney * 0.1;
                    winDays++;
                }
                else
                {
                    loseDays++;
                }
            }

            if (winDays > loseDays)
            {
                charityMoney += charityMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {charityMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {charityMoney:f2}");
            }

           

        }
    }
}

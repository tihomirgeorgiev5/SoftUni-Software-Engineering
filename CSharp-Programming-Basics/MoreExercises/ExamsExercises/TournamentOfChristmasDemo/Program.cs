using System;

namespace Tournament_of_Christmas___demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var countWin = 0;
            var countLose = 0;
            var money = 0.0;
            var countWinFinal = 0;
            var ccountLoseFinal = 0;
            var totalMoney = 0.0;
            for (int i = 1; i <= n; i++)
            {
                var sport = Console.ReadLine();
                while (sport != "Finish")
                {
                    var text = Console.ReadLine();

                    if (text == "win")
                    {
                        money += 20;
                        countWin++;
                    }
                    else
                    {

                        countLose++;

                    }
                    sport = Console.ReadLine();
                }
                if (countWin > countLose)
                {
                    money += money * 0.1;
                }
                totalMoney += money;
                money = 0.0;
                countWinFinal += countWin;
                ccountLoseFinal += countLose;
                countWin = 0;
                countLose = 0;
            }
            if (countWinFinal > ccountLoseFinal)
            {
                totalMoney = totalMoney * 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}

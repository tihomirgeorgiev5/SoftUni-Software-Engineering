using System;

namespace Change_бюро
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinsCount = int.Parse(Console.ReadLine());
            double chineseMoney = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double levOne = 1;
            double bitcoinsOne = 1168 * levOne;
            double usdOne = 1.76 * levOne;
            double chineseMoneyOne = 0.15 * usdOne;
            double euroOne = 1.95 * levOne;

            double chinesemoneyOnePerLevs = 0.15 * 1.76;

            double bitcoinsTotal = bitcoinsCount * 1168; //leva
            double chineseMoneyTotal = chinesemoneyOnePerLevs * chineseMoney;// leva

            double moneyTotalInLevs = bitcoinsTotal + chineseMoneyTotal;
            double moneyTotalInEuro = moneyTotalInLevs / 1.95;

            double commissionWithoutPercent = commission * 0.01;

            double moneyTotalAfterCom = moneyTotalInEuro - moneyTotalInEuro * commissionWithoutPercent;

            Console.WriteLine($"{moneyTotalAfterCom:f2}");
        }


    }
}

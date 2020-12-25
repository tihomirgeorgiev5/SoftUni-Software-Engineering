using System;

namespace _6.Blagotvoritelnost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Торта - 45 лв.

            //Гофрета - 5.80 лв.

            //Палачинка – 3.20 лв.
            

            int days = int.Parse(Console.ReadLine());
            int bakersCount = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int waffels = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            //Изчисляваме сумата, която се изкарва на ден
            int cakesProfitForOneDay = cakesCount * 45;
            double wafflesProfitForOneDay = waffels * 5.80;
            double pancakesProfitForOneDay = pancakes * 3.20;

            double totalProfitForOneDay = (cakesProfitForOneDay +
                wafflesProfitForOneDay + pancakesProfitForOneDay) * bakersCount;
            


            //Сума събрана от цялата кампания
            double totProfitForTheCampaign = totalProfitForOneDay * days;

            //Сума след покриване на разходите 
            double expences = 1 / 8.0;

            double result = totProfitForTheCampaign - (totProfitForTheCampaign * expences);
            Console.WriteLine(result);

        }
    }
}

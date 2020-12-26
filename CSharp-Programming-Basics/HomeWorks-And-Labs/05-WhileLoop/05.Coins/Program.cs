using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            //машините си да връщат възможно най - малко монети ресто.
            //Напишете програма, която приема сума -рестото,
            //което трябва да се върне и изчислява с колко най-малко монети може да стане това

            double change = double.Parse(Console.ReadLine());
            double changeInCoins = Math.Floor(change * 100);

            int count = 0;

            while (changeInCoins != 0)
            {
                if (changeInCoins >= 200)
                {
                    changeInCoins -= 200;
                    count++;
                }
                else if (changeInCoins >= 100)
                {
                    changeInCoins -= 100;
                    count++;
                }
                else if (changeInCoins >= 50)
                {
                    changeInCoins -= 50;
                    count++;
                }
                else if (changeInCoins >= 20)
                {
                    changeInCoins -= 20;
                    count++;
                }
                else if (changeInCoins >= 10)
                {
                    changeInCoins -= 10;
                    count++;
                }
                else if (changeInCoins >= 5)
                {
                    changeInCoins -= 5;
                    count++;
                }
                else if (changeInCoins >= 2)
                {
                    changeInCoins -= 2;
                    count++;
                }
                else if (changeInCoins >= 1)
                {
                    changeInCoins -= 1;
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}

using System;

namespace _05._Excursion_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int exSea = int.Parse(Console.ReadLine());
            int exMountian = int.Parse(Console.ReadLine());

            int counterSea = exSea;
            int counterMountian = exMountian;
            int totalPrice = 0;

            while (true)
            {

                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                if (command == "sea")
                {
                    if (counterSea > 0)
                    {
                        totalPrice += 680;
                        counterSea--;
                    }
                }
                else if (command == "mountain")
                {
                    if (counterMountian > 0)
                    {
                        totalPrice += 499;
                        counterMountian--;
                    }
                }

                if (counterMountian == 0 && counterSea == 0)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }

            }
            Console.WriteLine($"Profit: {totalPrice} leva.");

        }
    }
}

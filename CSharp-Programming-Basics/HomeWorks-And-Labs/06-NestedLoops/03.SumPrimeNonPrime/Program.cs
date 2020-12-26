using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeNumberSum = 0;
            int nonPrimeNumberSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 2; i <= number - 1; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primeNumberSum += number;
                    }
                    else
                    {
                        nonPrimeNumberSum += number;
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumberSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumberSum}");


        }
    }
}

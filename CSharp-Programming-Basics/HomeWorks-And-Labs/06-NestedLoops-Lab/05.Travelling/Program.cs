using System;
using System.Security.Cryptography;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            int minBudget = int.Parse(Console.ReadLine());

            while (true)
            {
                int currentSum = int.Parse(Console.ReadLine());
                currentSum++;

                if (currentSum == minBudget)
                {
                    Console.WriteLine($"Going to {destination}");
                }

                while (destination != "End")
                {
                    currentSum++;
                    if (currentSum == minBudget)
                    {
                        Console.WriteLine($"Going to {destination}");
                    }
                    currentSum = int.Parse(Console.ReadLine());

                }

                if (destination == "End")
                {
                    break;
                }

            }
            
            
        }
    }
}

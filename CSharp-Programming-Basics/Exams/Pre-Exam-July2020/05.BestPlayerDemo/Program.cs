 using System;

namespace _05._Best_Player_3Variant
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();
            int numGoals = int.Parse(Console.ReadLine());

            int maxGoals = int.MinValue;
            string bestPlayer = string.Empty;

            while (true)
            {
                
                if (maxGoals < numGoals)
                {
                    maxGoals = numGoals;
                    bestPlayer = namePlayer;    
                }
                if (numGoals >= 10)
                {
                    Console.WriteLine($"{namePlayer} is the best player!");
                    Console.WriteLine($"He has scored {numGoals} goals and made a hat-trick !!!");
                    break;
                }
                namePlayer = Console.ReadLine();
                if (namePlayer == "END")
                {
                    break;
                }
                numGoals = int.Parse(Console.ReadLine());
            }
            if (namePlayer == "END")
            {
                Console.WriteLine($"{bestPlayer} is the best player!");

                if (maxGoals >= 3)
                {
                    Console.WriteLine($"He has scored {numGoals} goals and made a hat-trick !!!");

                }
                else
                {
                    Console.WriteLine($"He has scored {numGoals} goals.");

                }
            }
        }
    }
}

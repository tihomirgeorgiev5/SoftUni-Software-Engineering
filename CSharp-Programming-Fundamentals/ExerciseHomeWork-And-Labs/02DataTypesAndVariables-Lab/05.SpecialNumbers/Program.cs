using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
           
            
            

            for (int i = 1; i <= input; i++)
            {
                int number = i;
                int sumDigits = 0;
                while (number > 0)
                {
                    sumDigits += number % 10;
                    
                    number = number / 10;

                }
                bool isSpecial = (sumDigits == 5 || sumDigits == 7 || sumDigits == 11);
                
               
                Console.WriteLine($"{i} -> {isSpecial}");

            }
        }
    }
}

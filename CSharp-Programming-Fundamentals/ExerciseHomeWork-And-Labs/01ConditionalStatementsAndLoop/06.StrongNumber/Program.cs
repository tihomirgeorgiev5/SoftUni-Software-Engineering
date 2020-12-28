using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;
            int currentNumber = 0;
            int factoralSum = 0;

            while (number != 0)
            {
                currentNumber = number % 10;
                number /= 10;

                int factorial = 1;

                for (int i = 1; i <=currentNumber; i++)
                {
                    factorial *= i;

                }
                factoralSum += factorial;

            }
            string result = string.Empty;
            if (input == factoralSum)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }
            Console.WriteLine(result);
        }
    }
}

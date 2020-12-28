using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            int sumOfChar = 0;

            for (int i = 1; i <= numOfLines ; i++)
            {
                char a = char.Parse(Console.ReadLine());
                int aToInt = (int)a;
                sumOfChar += aToInt;
            }
            Console.WriteLine($"The sum equals: {sumOfChar}");
        }
    }
}

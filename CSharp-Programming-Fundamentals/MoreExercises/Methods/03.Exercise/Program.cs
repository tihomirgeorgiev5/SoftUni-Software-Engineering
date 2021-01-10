using System;

namespace _03.Exercise_
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            CountsBetweenTwoChars(a, b);
        }
        static void CountsBetweenTwoChars (string a, string b)
        {
            char firstChar = char.Parse(a);
            char secondChar = char.Parse(b);
            int currentChar = 0;



            if (firstChar < secondChar)
            {
                for (int i = (int)firstChar + 1; i < (int)secondChar; i++)
                {
                    Console.Write((char)i + " ");

                }
            }
            else if (secondChar < firstChar)
            {
                for (int i = (int)secondChar + 1; i < (int)firstChar; i++)
                {
                    Console.Write((char)i + " ");

                }
            }
            
        }
    }
}

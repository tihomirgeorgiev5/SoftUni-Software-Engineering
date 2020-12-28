using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            CountVowels(input);
        }
        static void CountVowels(string input)
        {
            int vowelsCounter = 0;
            char[] vowels = new char[] {'a','o','u','e','i'};

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    vowelsCounter++;
                }
            }
            Console.WriteLine(vowelsCounter);
            
        }
    }
}

using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == ' ')
                {
                    continue;
                }

                if (charOccurrences.ContainsKey(symbol))
                {
                    charOccurrences[symbol]++;
                }
                else
                {
                    charOccurrences.Add(symbol, 1);
                }


            }
            foreach (var pair in charOccurrences)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}

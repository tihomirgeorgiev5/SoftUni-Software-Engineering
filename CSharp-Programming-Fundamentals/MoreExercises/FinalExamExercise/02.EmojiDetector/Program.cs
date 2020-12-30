using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";
            string numberPattern = @"\d";
            string text = Console.ReadLine();

            Regex numReg = new Regex(numberPattern);
            Regex emojiReg = new Regex(emojiPattern);

            /* You have to get your cool threshold. 
             * It is obtained by multiplying all the digits found in the input.
             * The cool threshold could be a very big number, so be mindful.
             * */

            long coolThreshold = 1;
            numReg.Matches(text)
                .Select(m => m.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(x => coolThreshold *= x);

            var matches = emojiReg.Matches(text);
            int totalEmojis = matches.Count;
            List<string> coolemojis = new List<string>();

            foreach (Match match  in matches)
            {
                long coolIndex = match.Value
                    .Substring(2, match.Value.Length - 4)
                    .ToCharArray()
                    .Sum(x => (int)x);

                if (coolIndex > coolThreshold)
                {
                    coolemojis.Add(match.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{totalEmojis} emojis found in the text. The cool ones are:");

            foreach (var item in coolemojis)
            {
                Console.WriteLine(item);
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @">>(?<name>[A-Za-z].*)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";

            double totalPrice = 0;
            List<string> furnitures = new List<string>();
            while (true)
            {
                if (text == "Purchase")
                {
                    break;
                }

                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(text);

                foreach (Match match in matches)
                {
                    furnitures.Add(match.Groups["name"].Value);
                    totalPrice += double.Parse(match.Groups["price"].Value) 
                        * double.Parse(match.Groups["quantity"].Value);

                }


                text = Console.ReadLine();

            }
            Console.WriteLine("Bought furniture:");

            if (totalPrice > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnitures).Trim());
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}

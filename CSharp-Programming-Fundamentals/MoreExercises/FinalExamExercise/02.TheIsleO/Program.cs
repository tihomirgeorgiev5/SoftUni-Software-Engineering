using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02_The_Isle_O
{
    class Program
    {
        static void Main(string[] args)
        {


            
            
            

            while (true)
            {
                string input = Console.ReadLine();
                string pattern = @"([#$%*&])(\w+)\1=(\d+)!!(.+)";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups[2].Value;
                    int length = int.Parse(match.Groups[3].Value);
                    string geonashCode = match.Groups[4].Value;

                    if (length == geonashCode.Length)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < geonashCode.Length; i++)
                        {
                            sb.Append((char)(geonashCode[i] + length));
                        }
                        Console.WriteLine($"Coordinates found! {name} -> " +
                            $"{sb.ToString()}");
                        break;
                    }
                }
                Console.WriteLine("Nothing found!");
            }


           
            

            
        }
    }
}

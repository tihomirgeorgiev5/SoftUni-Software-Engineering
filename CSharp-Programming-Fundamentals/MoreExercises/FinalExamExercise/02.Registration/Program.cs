using System;
using System.Text.RegularExpressions;

namespace _02_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countSuccess = 0;
            string pattern =
                @"U\$([A-Z][a-z]{3,})U\$P\@\$([a-z]{5,}\d+)P\@\$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    countSuccess++;
                    string username = match.Groups[1].Value;
                    string password = match.Groups[2].Value;

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username:{username}, Password:{password}");
                    
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {countSuccess}");

        }
    }
}

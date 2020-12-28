using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {
                string current = usernames[i];

                if (current.Length >= 3 && current.Length <= 16)
                {
                    bool isValid = true;
                    for (int j = 0; j < current.Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(current[j]) 
                            || current[j] == '-' 
                            || current[j] == '_'))
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        validUsernames.Add(current);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }
    }
}

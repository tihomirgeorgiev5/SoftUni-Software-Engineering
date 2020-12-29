using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "Done")
                {
                    break;
                }
                string[] current = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currentCommand = current[0];

                switch (currentCommand)
                {
                    case "Change":
                        string symbol = current[1];
                        string replacement = current[2];
                        for (int i = 0; i < input.Length; i++)
                        {
                            input = input.Replace(symbol, replacement);
                        }
                        Console.WriteLine(input);
                       
                        break;
                    case "Includes":
                        string otherString = current[1];
                        if (input.Contains(otherString))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
    
                        break;
                    case "End":
                        string end = current[1];
                        if (input.Length.Equals(end))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Uppercase":
                        input = input.ToUpper();
                        Console.WriteLine(input);
                           
                        break;
                    case "FindIndex":
                        string symbolChar = current[1];
                        int numberIndex = input.IndexOf(symbolChar);
                        Console.WriteLine(numberIndex);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(current[1]);
                        int length = int.Parse(current[2]);
                        //int total = startIndex + length;

                        input = input.Substring(startIndex, length);
                        Console.WriteLine(input);

                        
                        
                       
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}

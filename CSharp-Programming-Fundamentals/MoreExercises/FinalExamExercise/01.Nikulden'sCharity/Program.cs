using System;

namespace _01.Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "Finish")
                {
                    break;
                }
                string[] commandArgument = command.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgument[0];
                switch (action)
                {
                    case "Replace":
                        string currentChar =
                            commandArgument[1];
                        string newChar =
                            commandArgument[2];
                        input = input.Replace(currentChar, newChar);
                        Console.WriteLine(input);
                        break;
                   case "Cut":
                       int startIndex = int.Parse(commandArgument[1]);
                       int endIndex = int.Parse(commandArgument[2]);
                       if (startIndex < 0|| endIndex < 0 ||
                           startIndex >= input.Length ||
                           endIndex >= input.Length)
                       {
                           Console.WriteLine("Invalid indexes!");
                       }
                       else
                       {
                           input = input.Remove(startIndex, endIndex);
                           Console.WriteLine(input);
                       }
                       
                   
                       break;
                   case "Make":
                       string upOrLower = commandArgument[1];
                       if (upOrLower == "Upper")
                       {
                           input = input.ToUpper();
                           Console.WriteLine(input);
                       }
                       else if (upOrLower == "Lower")
                       {
                           input = input.ToLower();
                           Console.WriteLine(input);
                       }
                   
                       break;
                   case "Check":
                       string check = commandArgument[1];
                       if (input.Contains(check))
                       {
                           Console.WriteLine($"Message contains {check}"); ;
                       }
                       else
                       {
                           Console.WriteLine($"Message doesn't contain {check}");
                       }
                   
                       break;
                    case "Sum":
                        int startSubIndex = int.Parse(commandArgument[1]);
                        int endSubIndex = int.Parse(commandArgument[2]);
                        int sumIndexes = 0;
                       
                        if (startSubIndex < 0 || endSubIndex < 0 ||
                            startSubIndex >= input.Length ||
                            endSubIndex >= input.Length)
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        else
                        {
                            string substring = input.Substring(startSubIndex, endSubIndex);
                            for (int i = 0; i < substring.Length; i++)
                            {
                                sumIndexes += (int)input[i];
                            }
                            Console.WriteLine(sumIndexes);
                   
                        }
                        
                        break;

                    default:
                        break;
                }









                command = Console.ReadLine();
            }
        }
    }
}

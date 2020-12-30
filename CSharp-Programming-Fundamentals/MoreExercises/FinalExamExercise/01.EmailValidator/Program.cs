using System;

namespace _01.Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "Complete")
                {
                    break;
                }

                string[] commandArg = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandArg[0];
                switch (currentCommand)
                {
                    
                    case "Make":
                        
                            string secondCommand = commandArg[1];


                        if (secondCommand == "Upper")
                        {
                            input = input.ToUpper();
                            Console.WriteLine(input);
;
                        }
                        else if (secondCommand == "Lower")
                        {
                            input = input.ToLower();
                            Console.WriteLine(input);
                        }


                            break;
                    case "GetDomain":
                        int count = int.Parse(commandArg[1]);
                        string domain = input.Substring(input.Length - count, count);
                        Console.WriteLine(domain);
                        break;
                    case "GetUsername":
                        if (!input.Contains('@'))
                        {
                            Console.WriteLine($"The email {input} doesn't contain the @ symbol");
                        }
                        else
                        {
                            int index = input.IndexOf('@');
                            string username = input.Substring(0, index);
                            Console.WriteLine(username);
                            
                        }
                        break;
                    case "Replace":
                        char symbol = char.Parse(commandArg[1]);
                        char newSymbol = '-';
                        input = input.Replace(symbol, newSymbol);
                        Console.WriteLine(input);
                        
                        break;
                    case "Encrypt":
                        for (int i = 0; i < input.Length; i++)
                        {

                            Console.Write($"{(int)input[i]} ");
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

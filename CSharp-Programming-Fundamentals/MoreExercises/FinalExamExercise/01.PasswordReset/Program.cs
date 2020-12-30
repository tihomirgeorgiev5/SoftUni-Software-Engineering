using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Done")
                {
                    break;
                }
                string[] comArgument = input.Split();
                string command = comArgument[0];
                

                switch (command)
                {
                    case "TakeOdd":
                        StringBuilder stringBuilder = new StringBuilder();
                        for (int i = 0; i < password.Length; i++)
                        {
                            if(i % 2 != 0)
                            {
                                stringBuilder.Append(password[i]);
                            }
                        }
                        password = stringBuilder.ToString();
                        Console.WriteLine(password);


                        break;
                    case "Cut":
                        int index = int.Parse(comArgument[1]);
                        int length = int.Parse(comArgument[2]);
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                          
                        break;
                    case "Substitute":
                        string substring = comArgument[1];
                        string substitute = comArgument[2];
                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                        
                    default:
                        break;
                }









                input = Console.ReadLine();

            }

            Console.WriteLine($"Your password is: {password}");

        }
    }
}

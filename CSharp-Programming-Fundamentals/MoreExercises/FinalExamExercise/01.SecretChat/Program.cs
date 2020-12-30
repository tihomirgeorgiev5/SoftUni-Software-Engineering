using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Reveal")
                {
                    break;
                }

                string[] tokens = input.Split(":|:"
                    , StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(tokens[1]);
                        concealedMessage = concealedMessage.Insert(index," ");
                        break;
                    case "Reverse":
                        var substring = tokens[1];
                        if (concealedMessage.Contains(substring))
                        {
                            concealedMessage = concealedMessage.Remove(concealedMessage.IndexOf(substring)
                                , substring.Length);

                            var reversed = new string(substring.Reverse().ToArray());
                            concealedMessage += reversed;
                        }
                        else
                        {
                            input = Console.ReadLine();
                            Console.WriteLine("error");
                            continue;
                        }
                        break;

                    case "ChangeAll":
                        var substringToChange = tokens[1];
                        var replacement = tokens[2];

                        concealedMessage =
                            concealedMessage.
                            Replace(substringToChange, replacement);


                        break;

                  
                }

                Console.WriteLine(concealedMessage);



                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
           

        }
    }
}

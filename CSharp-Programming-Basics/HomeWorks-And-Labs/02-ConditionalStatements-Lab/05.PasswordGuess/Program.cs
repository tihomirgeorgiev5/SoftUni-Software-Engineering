using System;

namespace _05._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която чете парола(един ред с произволен текст), 
            //въведена от потребителя и проверява, дали въведеното съвпада с фразата "s3cr3t!P@ssw0rd".
            //При съвпадение да се изведе "Welcome".При несъвпадение да се изведе "Wrong password!".

            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");

            }

        }
    }
}

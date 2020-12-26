using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int num = 0;
            int i = 0;

            int min = int.MaxValue;

            while (command != "Stop")
            {
                num = int.Parse(command);
                i++;
                if (num < min)
                {
                    min = num;


                }
                command = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}

using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int num = 0;
            int i = 0;
            
            int max = int.MinValue;

            while (command != "Stop")
            {
                num = int.Parse(command);
                i++;
                if (num > max)
                {
                    max = num;
                    
                    
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(max);


        }
    }
}

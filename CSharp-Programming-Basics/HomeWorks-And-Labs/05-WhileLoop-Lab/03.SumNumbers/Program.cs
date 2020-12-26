using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            
            

            while (true)
            {
                int currentNummer = int.Parse(Console.ReadLine());
                
                sum += currentNummer;
                if (sum >= number)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }

            

        }
    }
}

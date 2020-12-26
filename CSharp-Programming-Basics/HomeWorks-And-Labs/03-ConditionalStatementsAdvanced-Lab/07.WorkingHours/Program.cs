using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourDayAndNignt = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();


            if (hourDayAndNignt >= 10 && hourDayAndNignt <= 18 && weekDay != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }

        }
    }
}

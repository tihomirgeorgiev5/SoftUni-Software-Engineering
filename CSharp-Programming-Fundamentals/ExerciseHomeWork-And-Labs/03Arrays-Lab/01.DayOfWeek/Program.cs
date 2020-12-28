using System;
using System.Linq;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDay = int.Parse(Console.ReadLine());

            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (numOfDay < 1 || numOfDay > days.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[numOfDay-1]);
            }

        }
    }
}

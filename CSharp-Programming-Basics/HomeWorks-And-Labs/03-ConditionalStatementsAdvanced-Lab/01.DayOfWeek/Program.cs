using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeekAsNumber = int.Parse(Console.ReadLine());

            switch (dayOfWeekAsNumber)
            {
                case 1:
                case 2:
                case 3:
                   
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;



            }
        }
    }
}

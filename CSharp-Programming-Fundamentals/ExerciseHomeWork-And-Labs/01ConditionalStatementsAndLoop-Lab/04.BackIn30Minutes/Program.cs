using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeAfterPause = minutes + 30; 

            if (timeAfterPause > 59)
            {
                hours++;
                timeAfterPause -= 60;

            }
            if(hours > 23)
            {
                hours -= 24;


            }


            Console.WriteLine($"{hours}:{timeAfterPause:d2}");



        }
    }
}

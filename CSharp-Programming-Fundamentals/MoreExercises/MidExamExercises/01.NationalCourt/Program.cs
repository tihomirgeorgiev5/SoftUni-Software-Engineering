using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int countPeoplePerHour = int.Parse(Console.ReadLine());

            int sumPeoplePerHour = firstEmployee + secondEmployee + thirdEmployee;


            int hours = 0;
            
            
            while (countPeoplePerHour > 0)
            {
                countPeoplePerHour -= sumPeoplePerHour;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
           
            

            
        }
    }
}

using System;


namespace _06._Passengers_Per_Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            int flights = int.Parse(Console.ReadLine());
            string bestName = string.Empty;
            int bestAverage = 0;

            for (int i = 0; i < flights; i++)
            {

                int passangers = 0;
                int countFlights = 0;


                string nameOfCompany = Console.ReadLine();


                while (nameOfCompany != "Finish")
                {
                    string command2 = Console.ReadLine();


                    if (command2 == "Finish")
                    {
                        int average = passangers / countFlights;

                        Console.WriteLine($"{nameOfCompany}: {average} passengers.");

                        if (average > bestAverage)
                        {
                            bestAverage = average;
                            bestName = nameOfCompany;
                        }

                        break;
                    }
                    countFlights++;

                    passangers += int.Parse(command2);
                   


                }


            }
            Console.WriteLine($"{bestName} has most passengers per flight: {bestAverage}");
        }
    }
}
 
 
 
 
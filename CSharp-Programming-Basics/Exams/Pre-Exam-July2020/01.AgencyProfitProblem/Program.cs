using System;

namespace _01Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string avioName = Console.ReadLine();
            int ticketsAdultsCount = int.Parse(Console.ReadLine());
            int ticketsChildCount = int.Parse(Console.ReadLine());
            double ticketAdultPrice = double.Parse(Console.ReadLine());
            double serviceTax = double.Parse(Console.ReadLine());

            double ticketChildPrice = ticketAdultPrice * 0.3;
            double ticketAdultTotal = ticketAdultPrice + serviceTax;
            double ticketChildTotal = ticketChildPrice + serviceTax;

            double ticketsTotalPrice = ticketsAdultsCount * ticketAdultTotal + ticketsChildCount * ticketChildTotal;

            double profitTotal = ticketsTotalPrice * 0.2;

            Console.WriteLine($"The profit of your agency from {avioName} tickets is {profitTotal:f2} lv.");

        }
    }
}

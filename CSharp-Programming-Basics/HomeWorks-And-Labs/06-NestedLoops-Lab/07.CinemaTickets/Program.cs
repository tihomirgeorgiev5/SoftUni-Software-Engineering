using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            	//На първия ред до получаване на командата "Finish" - име на филма – текст
	            //На втори ред – свободните места в салона за всяка прожекция – цяло число[1 … 100]
	            //За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
	            //Типа на закупения билет -текст("student", "standard", "kid")

            string movieName = Console.ReadLine();

            int kidsTickets = 0;
            int standardTickets = 0;
            int studentTickets = 0;

            while (movieName != "Finish")
            {
                int availableSeates = int.Parse(Console.ReadLine());
                int seatsTaken = 0;
                string ticketType = Console.ReadLine();
                while (ticketType != "End")
                {
                    switch (ticketType)
                    {
                        case "kid":
                            kidsTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                    }

                    seatsTaken++;
                    if (seatsTaken == availableSeates)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                double percenttageFull = seatsTaken * 1.0 / availableSeates * 100;
                Console.WriteLine($"{movieName} - {percenttageFull:f2}% full.");
                movieName = Console.ReadLine();
            }

            int totalTickets = kidsTickets + standardTickets + studentTickets;

            double kidsTicketsPercent = kidsTickets * 1.0 / totalTickets * 100;
            double standardTicketsPercent = standardTickets * 1.0 / totalTickets * 100;
            double studentTicketsPercent = studentTickets * 1.0 / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidsTicketsPercent:f2}% kids tickets.");
            
            
        }
    }
}

using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

           // Write a program, which prints the language,
           // that a given country speaks. 
           // You can receive only the following combinations:
           // English is spoken in England and USA;
           // Spanish is spoken in Spain, Argentina and Mexico;
           // for the others, we should print "unknown".

            switch (country)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;

            }
        }
    }
}

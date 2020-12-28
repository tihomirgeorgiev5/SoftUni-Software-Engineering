using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double totalPrice = 0;

            switch(typeOfGroup)
            {
                case "Students":
                  
                  if (dayOfWeek == "Friday")
                    {
                        totalPrice = countPeople * 8.45;
                    }
                  else if (dayOfWeek == "Saturday")
                    {
                        totalPrice = countPeople* 9.80;
                    }
                  else if (dayOfWeek == "Sunday")
                    {
                        totalPrice = countPeople * 10.46;
                    }
                   if (countPeople >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Business":
                    if (countPeople >= 100)
                    {
                        countPeople -= 10;
                    }
                    if (dayOfWeek == "Friday")
                    {
                        totalPrice = countPeople * 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        totalPrice = countPeople * 15.60;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        totalPrice = countPeople * 16;
                    }
                    
                    break;
                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        totalPrice = countPeople * 15;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        totalPrice = countPeople * 20;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        totalPrice = countPeople * 22.50;
                    }
                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;

            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
            

        }
    }
}

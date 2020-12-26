using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double pricePerUnit = 0.00;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit == "banana")
                    {
                        pricePerUnit = 2.50;
                    }
                    else if (fruit == "apple")
                    {
                        pricePerUnit = 1.20;
                    }
                    else if (fruit == "orange")
                    {
                        pricePerUnit = 0.85;
                    }
                    else if (fruit == "grapefruit")
                    {
                        pricePerUnit = 1.45;
                    }
                    else if (fruit == "kiwi")
                    {
                        pricePerUnit = 2.70;
                    }
                    else if (fruit == "pineapple")
                    {
                        pricePerUnit = 5.50;
                    }
                    else if (fruit == "grapes")
                    {
                        pricePerUnit = 3.85;
                    }
                    break;
                    
                case "Saturday":
                case "Sunday":
                    if (fruit == "banana")
                    {
                        pricePerUnit = 2.70;
                    }
                    else if (fruit == "apple")
                    {
                        pricePerUnit = 1.25;
                    }
                    else if (fruit == "orange")
                    {
                        pricePerUnit = 0.90;
                    }
                    else if (fruit == "grapefruit")
                    {
                        pricePerUnit = 1.60;
                    }
                    else if (fruit == "kiwi")
                    {
                        pricePerUnit = 3.00;
                    }
                    else if (fruit == "pineapple")
                    {
                        pricePerUnit = 5.60;
                    }
                    else if (fruit == "grapes")
                    {
                        pricePerUnit = 4.20;
                    }
                    break;
                



            }
            double totalPrice = pricePerUnit * quantity;

            if (totalPrice > 0)
            {
                Console.WriteLine($"{totalPrice:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            

            
        }
    }
}

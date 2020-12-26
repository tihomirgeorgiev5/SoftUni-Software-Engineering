using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int nights = days - 1;
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double pricePerNight = 0;
            if (roomType == "room for one person")
            {
                pricePerNight = 18.00;
            }
            else if (roomType == "apartment")
            {
                pricePerNight = 25.00;
            }
            else
            {
                pricePerNight = 35.00;
            }

            int discountPercentage = 0;

            if (roomType == "apartment")
            {
                if (days < 10)
                {
                    discountPercentage = 30;
                }
                else if (days >= 10 && days <= 15)
                {
                    discountPercentage = 35;
                }
                else if (days > 15)
                {
                    discountPercentage = 50;
                }
            }
            else if (roomType == "president apartment")
            {
                if (days < 10)
                {
                    discountPercentage = 10;
                }
                else if (days >= 10 && days <= 15)
                {
                    discountPercentage = 15;
                }
                else if (days > 15)
                {
                    discountPercentage = 20;
                }
            }
            double totalPrice = nights * pricePerNight;

            if (discountPercentage != 0)
            {
                double discountMoney = totalPrice * discountPercentage / 100.0;
                totalPrice = totalPrice - discountMoney;
            }
            if (rating == "positive")
            {
                totalPrice = totalPrice * 1.25;
            }
            else
            {
                totalPrice = totalPrice * 0.9;
            }

            Console.WriteLine($"{totalPrice:f2}");




        }
    }
}

using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //дали ще успее да събере необходимата сума
            //Тя спестява или харчи част от парите си всеки ден.
            //Ако иска да похарчи повече от наличните си пари, 
            //то тя ще похарчи колкото има и ще ѝ останат 0 лева.

            
            double tripPrice = double.Parse(Console.ReadLine());
            double startingMoney = double.Parse(Console.ReadLine());

            int totalDays = 0;
            int daysSpend = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());

                totalDays++;

                if (action == "spend")
                {
                    daysSpend++;
                    startingMoney -= currentMoney;

                    if (startingMoney < 0)
                    {
                        startingMoney = 0;
                    }

                    if (daysSpend == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine($"{totalDays}");
                        break;
                    }

                }
                else if (action == "save")
                {
                    startingMoney += currentMoney;
                    daysSpend = 0;
                }
                if (startingMoney >= tripPrice)
                {
                    Console.WriteLine($"You saved the money for {totalDays} days.");
                    break;
                }
            }

            //Програмата трябва да приключи при следните случаи:
            //⦁	Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
            //⦁	"You can't save the money."
            //⦁	"{Общ брой изминали дни}"
            //⦁	Ако Джеси събере парите за почивката на конзолата се изписва:
            //⦁	"You saved the money for {общ брой изминали дни} days."




        }
    }
}

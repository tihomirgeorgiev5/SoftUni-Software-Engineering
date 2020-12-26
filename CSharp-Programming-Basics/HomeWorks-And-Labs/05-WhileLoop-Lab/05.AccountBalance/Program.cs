using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
               // Напишете програма, която пресмята колко общо пари има в сметката,
               // след като направите определен брой вноски.
               // На всеки ред ще получавате сумата, която трябва да внесете в сметката,
               // до получаване на команда "NoMoreMoney".
               // При всяка получена сума на конзолата трябва да се извежда "Increase: " + сумата
               // и тя да се прибавя в сметката.
               // Ако получите число по-малко от 0 на конзолата трябва да се изведе "Invalid operation!" 
               // и програмата да приключи. 
               // Когато програмата приключи трябва да се принтира "Total: " + общата сума в сметката закръглена до втория знак след десетичната запетая

            
            

            double total = 0;
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    break;
                }

                double number = double.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += number;
                Console.WriteLine($"Increase: {number:f2}");

            }

            Console.WriteLine($"Total: {total:f2}");
           

          

        }
    }
}

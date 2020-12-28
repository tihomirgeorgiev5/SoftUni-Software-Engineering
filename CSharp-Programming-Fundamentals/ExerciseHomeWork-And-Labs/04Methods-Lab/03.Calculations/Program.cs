using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeAction = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (typeAction)
            {
                case "add":
                    add(num1, num2);
                    break;
                case "subtract":
                    subtract(num1, num2);
                    break;
                case "multiply":
                    multiply(num1, num2);
                    break;
                case "divide":
                    divide(num1, num2);
                    break;
                    


            }



        }

        private static void divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }

        private static void multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        private static void subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        private static void add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}

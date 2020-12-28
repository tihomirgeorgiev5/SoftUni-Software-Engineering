using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(num1, sign, num2));
        }
        static double Calculate(double num1, string sign, double num2)
        {
            double result = 0;
            if (sign == "/")
            {
                result = num1 / num2;
            }
            else if(sign == "*")
            {
                result = num1 * num2;
            }
            else if(sign == "+")
            {
                result = num1 + num2;
            }
            else if(sign == "-")
            {
                result = num1 - num2;
            }
            return result;
        }
    }
}

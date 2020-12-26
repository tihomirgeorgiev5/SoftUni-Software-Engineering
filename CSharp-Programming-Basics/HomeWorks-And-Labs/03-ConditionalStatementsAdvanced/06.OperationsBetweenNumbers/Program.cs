using System;

namespace _06.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result = 0;
            string type = string.Empty;
            string output = string.Empty;
            if (n2 == 0)
            {
                output = $"Cannot divide {n1} by zero";
            }
            else if (symbol == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    type = "even";
                }
                else
                {
                    type = "odd";
                }
                output = $"{n1} {symbol} {n2} = {result} - {type}";
            }
            else if (symbol == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    type = "even";
                }
                else
                {
                    type = "odd";
                }
                output = $"{n1} {symbol} {n2} = {result} - {type}";
            }
            else if (symbol == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    type = "even";
                }
                else
                {
                    type = "odd";
                }
                output = $"{n1} {symbol} {n2} = {result} - {type}";
            }
            else if (symbol == "/")
            {
                result = n1 * 1.0 / n2;
                output = $"{n1} / {n2} = {$"result:f2"}";
            }
            else if (symbol == "%")
            {
                result = n1 % n2;
                output = $"{n1} % {n2} = {result}";
            }
            Console.WriteLine(output);

        }
    }
}

using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal sum = 0.0M;

            for (int i = 1; i <=count; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;

            }
            Console.WriteLine(sum);
        }
    }
}

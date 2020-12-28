using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int total = integer * i;
                Console.WriteLine($"{integer} X {i} = {total}");
            }

        }
    }
}

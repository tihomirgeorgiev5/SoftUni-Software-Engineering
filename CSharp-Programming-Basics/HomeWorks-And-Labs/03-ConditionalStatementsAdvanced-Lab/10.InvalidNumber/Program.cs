using System;

namespace _10._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            bool isValid =  x >= 100 && x <= 200 || x == 0;
            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

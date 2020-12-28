using System;

namespace _04._Gifts_from_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            int startNumber = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());


            for (int i = startNumber; i >= endNumber; i--)
            {

                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == specialNumber)
                    {
                        break;
                    }
                    Console.Write($"{i} ");

                }
            }
        }
    }
}

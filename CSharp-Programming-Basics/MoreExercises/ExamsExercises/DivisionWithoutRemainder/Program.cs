using System;

namespace Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countFirst = 0;
            int countSecond = 0;
            int countThird = 0;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());


                if (value % 2 == 0)
                {
                    countFirst++;
                }
                if (value % 3 == 0)
                {
                    countSecond++;
                }
                if (value % 4 == 0)
                {
                    countThird++;
                }
            }
            double percentFirst = countFirst * 1.0/ n * 100;
            double percentSecond = countSecond * 1.0/ n * 100;
            double percentThird = countThird * 1.0/ n * 100;

            Console.WriteLine($"{percentFirst:f2}%");
            Console.WriteLine($"{percentSecond:f2}%");
            Console.WriteLine($"{percentThird:f2}%");
        }
    }
}

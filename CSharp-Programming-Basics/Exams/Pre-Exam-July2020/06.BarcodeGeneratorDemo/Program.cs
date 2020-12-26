using System;

namespace newTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int startThousand = startNum / 1000;
            int endThousand = endNum / 1000;
            int startHundred = (startNum % 1000) / 100;
            int endHundred = (endNum % 1000) / 100;
            int startTen = (startNum % 100) / 10;
            int endTen = (endNum % 100) / 10;
            int startOne = startNum % 10;
            int endOne = endNum % 10;

            for (int i = startThousand; i <= endThousand; ++i)
            {
                for (int j = startHundred; j <= endHundred; ++j)
                {
                    for (int k = startTen; k <= endTen; ++k)
                    {
                        for (int l = startOne; l <= endOne; ++l)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write(i);
                                Console.Write(j);
                                Console.Write(k);
                                Console.Write(l);
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
﻿using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int x1 = 1; x1 < 10; x1++)
            {
                for (int x2 = 1; x2 < 10; x2++)
                {
                    for (int x3 = 1; x3 < 10; x3++)
                    {
                        for (int x4 = 1; x4 < 10; x4++)
                        {
                            if (n % x1 == 0 &&
                                n % x2 == 0 &&
                                n % x3 == 0 &&
                                n % x4 == 0)

                            {
                                Console.Write($"{x1}{x2}{x3}{x4} ");
                            }
                            
                        }
                    }
                }
            }
        }
    }
}

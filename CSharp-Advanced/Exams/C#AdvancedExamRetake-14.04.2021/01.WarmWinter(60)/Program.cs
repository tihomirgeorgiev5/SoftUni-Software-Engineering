using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            // sequence of integers representing the hats
            // sequence of integers representing the scarfs

            Stack<int> hats = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int setsSum = 0;
            List<int> sums = new List<int>();
            int biggestSum = 0;

            


            while (hats.Count > 0 && scarfs.Count > 0)
            {
                
                int currentHat = hats.Peek();
                int currentScarf = scarfs.Peek();




                if (currentHat > currentScarf)
                {
                    setsSum = currentHat + currentScarf;
                    sums.Add(setsSum);
                    hats.Pop();
                    scarfs.Dequeue();
                }

                else if (currentScarf > currentHat)
                {
                    hats.Pop();

                }
                else if (currentHat == currentScarf)
                {
                    scarfs.Dequeue();
                    currentHat++;

                }


            }

            //for (int i = 0; i < sums.Count; i++)
            //{
            //
            //    if (i > biggestSum)
            //    {
            //        biggestSum = i;
            //    }
            //}
            //
            int max = sums.Max();
            Console.WriteLine($"The most expensive set is: {max}");

            Console.WriteLine(string.Join(" ", sums));


        }
    }
}

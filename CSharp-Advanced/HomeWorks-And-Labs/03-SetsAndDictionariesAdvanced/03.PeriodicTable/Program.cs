using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> hashSet = new HashSet<string>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                foreach (var item in input)
                {
                    hashSet.Add(item);
                }

            }
            var sorted = hashSet.OrderBy(h => h);
            Console.WriteLine(string.Join(" ",sorted));
        }
    }
}

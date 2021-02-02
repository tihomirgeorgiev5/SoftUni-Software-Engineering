using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(currentNum))
                {
                    dict.Add(currentNum, 0);
                }

                dict[currentNum]++;
            }

            foreach (var item in dict)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}

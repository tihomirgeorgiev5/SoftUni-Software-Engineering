using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = Console.ReadLine()
                 .Split();

            List<string> evenLength = fruits.Where(word => word.Length % 2 == 0).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, evenLength));
                 
        }
    }
}

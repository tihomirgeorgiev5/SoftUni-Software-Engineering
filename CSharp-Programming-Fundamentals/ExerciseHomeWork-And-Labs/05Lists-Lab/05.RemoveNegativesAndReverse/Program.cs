using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i -- );
                }
               
            }
            list.Reverse();
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }


            Console.WriteLine(String.Join(" ", list));
        }


    }
}

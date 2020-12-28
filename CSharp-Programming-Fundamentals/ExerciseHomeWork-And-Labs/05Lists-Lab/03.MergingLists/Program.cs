using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = ReadIntListSingleLine();
            List<int> secondList = ReadIntListSingleLine();

            Console.WriteLine(String.Join(" ", MergeLists(firstList, secondList)));


        }
        static List<int> ReadIntListSingleLine()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            return list;
        }
        static List<int> MergeLists(List<int> firstList, List<int> secondList)
        {
            int count = Math.Max(firstList.Count, secondList.Count);
            List<int> merged = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (firstList.Count > i)
                {
                    merged.Add(firstList[i]);
                }
                if (secondList.Count > i)
                {
                    merged.Add(secondList[i]);
                }
                
            }
            return merged;
        }


    }
}

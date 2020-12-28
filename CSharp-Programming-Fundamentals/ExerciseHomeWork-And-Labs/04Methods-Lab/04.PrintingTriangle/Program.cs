using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            PtintTriangle(limit); 
            
          
        }
        static void PtintTriangle(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                PrintNumsFrom1(i);
            }
            for (int i = limit - 1; i >= 1; i--)
            {
                PrintNumsFrom1(i);
            }
        }
        static void PrintNumsFrom1(int to)
        {
            for (int i = 1; i <= to; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
      
         
        


    }
}

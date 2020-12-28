using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumArr1 = 0;
            bool isIdentical = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] == arr2[i])
                {
                    int currentNumber = arr1[i];
                    sumArr1 += currentNumber;
                   

                    
                    
                }
                else if(arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

            }
            
            
                Console.WriteLine($"Arrays are identical. Sum: {sumArr1}");
            
            
                
            
                
        }
    }
}

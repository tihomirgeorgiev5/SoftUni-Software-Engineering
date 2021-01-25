using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> foods = new Queue<int>(orders);
            Console.WriteLine(foods.Max());



            while (foods.Any())
            {
               
                int food = foods.Peek();

                if (quantity >= food)
                {
                    quantity -= food;
                    foods.Dequeue();
                }
                else
                {
                    break;
                }
                
                

            }

            if (foods.Any())
            {
                Console.WriteLine("Orders left: " + string.Join(" ",foods));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
            
        }
    }
}

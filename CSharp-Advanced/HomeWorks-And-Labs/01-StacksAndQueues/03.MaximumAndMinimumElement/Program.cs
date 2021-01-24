using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                .Split(" ").ToArray();

                

                string command = input[0];
                
                switch (command.ToString())
                {
                    case "1":
                        int pushedEllement = int.Parse(input[1]);
                        numbers.Push(pushedEllement);
                        break;
                    case "2":
                        if (numbers.Any())
                        {
                            numbers.Pop();
                        }

                        break;
                    case "3":
                        if (numbers.Any())
                        {
                            Console.WriteLine(numbers.Max());
                        }

                        break;
                    case "4":
                        if (numbers.Any())
                        {
                            Console.WriteLine(numbers.Min());
                        }

                        break;

                    default:
                        break;
                }
            
                
            }
            

            

            Console.WriteLine(string.Join(", ", numbers));
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                .Split(", ").Select(int.Parse).ToArray());

            Queue<int> threads = new Queue<int>(Console.ReadLine()
                            .Split(" ").Select(int.Parse).ToArray());

            int taskToKill = int.Parse(Console.ReadLine());

            while(true)
            {
                if(tasks.Peek() == taskToKill)
                {
                    break;
                }
                if(threads.Peek() >= tasks.Peek())
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if(threads.Peek() < tasks.Peek())
                {
                    threads.Dequeue();

                }
            }

            Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToKill}");
            Console.WriteLine(string.Join(" ", threads));

            
        }
    }
}

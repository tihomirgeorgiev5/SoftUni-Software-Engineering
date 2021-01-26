using System;
using System.Collections.Generic;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(Console.ReadLine());
            }

            int length = queue.Count;
            int index = -1;

            for (int i = 0; i < length; i++)
            {
                bool isCompleted = true;
                int totalCapacity = 0;

                for (int j = 0; j < length; j++)
                {
                    string currValue = queue.Dequeue();
                    queue.Enqueue(currValue);

                    if (isCompleted)
                    {
                        string[] tokens = currValue.Split();
                        int amount = int.Parse(tokens[0]);
                        int distance = int.Parse(tokens[1]);

                        totalCapacity += amount - distance;

                        if (totalCapacity < 0)
                        {
                            isCompleted = false;
                        }

                    }
                }

                if (isCompleted)
                {
                    index = i;
                    break;
                }

                queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine(index);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsList = Console.ReadLine()
                .Split(", ").ToArray();

            Queue<string> songs = new Queue<string>(songsList);

            string command = Console.ReadLine();
            

            while (songs.Count > 0)
            {
                if (command.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string[] songToAdd = command.Split("Add ",StringSplitOptions.RemoveEmptyEntries);
                    
                    if (songs.Contains(songToAdd[0]))
                    {
                        Console.WriteLine($"{songToAdd[0]} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songToAdd[0]);
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",songs));
                }

                command = Console.ReadLine();




            }

            Console.WriteLine("No more songs");
        }
    }
}

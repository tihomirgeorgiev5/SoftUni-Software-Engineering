﻿using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

           
            int initialHealth = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currentRoom = rooms[i].Split();

                string command = currentRoom[0];
                int number = int.Parse(currentRoom[1]);

                if (command == "potion")
                {
                    int value = 0;
                    if (number + initialHealth <= 100)
                    {
                        value = number;
                    }
                    else
                    {
                        value = 100 - initialHealth;
                    }
                    initialHealth += value;
                    Console.WriteLine($"You healed for {value} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    initialHealth -= number;
                    if(initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                    
                  
                }
            }
            if (initialHealth > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {initialHealth}");

            }
            
        }
    }
}

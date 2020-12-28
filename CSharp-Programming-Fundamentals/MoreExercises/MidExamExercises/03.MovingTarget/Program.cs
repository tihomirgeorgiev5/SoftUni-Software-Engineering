using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End" )
            {
                string[] ellements = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string operation = ellements[0];
                int index = int.Parse(ellements[1]);
                int power = int.Parse(ellements[2]);

                if (index < 0 || index >= list.Count)
                {
                    if (operation == "Add")
                    {
                        Console.WriteLine("Invalid placement!");
                        
                    }
                    else if (operation == "Strike")
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    continue;
                }



                switch (operation)
                {
                    case "Shoot":
                        list[index] -= power;
                        if (list[index] <= 0)
                        {
                            list.RemoveAt(index);
                        }
                        
                        break;
                    case "Add":
                        list.Insert(index, power);
                        break;
                    case "Strike":
                        if (index - power < 0 || index + power >= list.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }

                        for (int i  = index - power; i <= index + power; i ++)
                        {
                            list.RemoveAt(index - power);
                        }
                        break;
                    default:
                        break;
                }



                
            }
            Console.WriteLine(string.Join("|", list));



        }
    }
}

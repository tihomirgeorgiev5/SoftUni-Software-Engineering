using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                 .Split("!", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string input;

            while ((input = Console.ReadLine()) !="Go Shopping!")
            {
                string[] commands = input.Split();



                if (commands[0] == "Urgent")
                {
                    if (!list.Contains(commands[1]))
                    {
                        list.Insert(0, commands[1]);
                        
                    }
                    
                    
                    
                    
                }

                else if (commands[0] == "Unnecessary")
                {
                    if (list.Contains(commands[1]))
                    {
                        list.Remove(commands[1]);
                    }
                    

                }

                else if (commands[0] == "Correct")
                {
                    

                   
                     for (int i = 0; i < list.Count; i++)
                     {
                         if (list[i] == (commands[1]))
                         {
                             list.Insert(i + 1, commands[2]);
                             list.RemoveAt(i);
                         }
                     }
                    

      
                }
                else if (commands[0] == "Rearrange")
                {
                    if (list.Contains(commands[1]))
                    {
                        list.Remove(commands[1]);
                        list.Add(commands[1]);
                    }
                }


            }
            Console.WriteLine(string.Join(", ",list));
            
        }
    }
}

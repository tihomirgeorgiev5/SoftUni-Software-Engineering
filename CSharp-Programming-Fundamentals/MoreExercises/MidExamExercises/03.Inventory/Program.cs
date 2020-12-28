using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine(); 
            
            while (input != "Craft!")
            {
                string[] collections = input.Split(" - ");
                string command = collections[0];
                string act = collections[1];

                if (command == "Collect")
                {
                    if (!items.Contains(act))
                    {
                        items.Add(act);
                    }
                    
                }
                else if (command == "Drop")
                {
                    if (items.Contains(act))
                    {
                        items.Remove(act);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] newOldItems = act.Split(":");

                    string oldItem = newOldItems[0];
                    string newItem = newOldItems[1];

                    int index = items.IndexOf(oldItem);

                    if (index >= 0)
                    {
                        items.Insert(index + 1, newItem);
                    }

                   
                }
                else if (command == "Renew")
                {
                    if (items.Contains(act))
                    {
                        int index = items.IndexOf(act);
                        items.RemoveAt(index);
                        items.Add(act);
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ",items));
        }

    }
}

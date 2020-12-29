using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string command = Console.ReadLine();
            List<string> list = new List<string>();

            while (command != "end")
            {
                

                string[] input = command.Split();

                if (input[0] == "Chat")
                {
                    string message = input[1];
                    list.Add(message);
                    
                }
                if (input[0] == "Delete")
                {
                    string messageToDelete = input[1];
                    if (list.Contains(messageToDelete))
                    {
                        list.Remove(messageToDelete);
                    }
                }
                if (input[0] == "Edit")
                {
                    string messageToEdit = input[1];
                    string editedVersion = input[2];
                    if (list.Contains(messageToEdit))
                    {
                        list.Remove(messageToEdit);
                    }
                    list.Add(editedVersion);

                }
                if (input[0] == "Pin")
                {
                    string message = input[1];
                    if (list.Contains(message))
                    {
                        list.Remove(message);
                        list.Add(message);
                    }

                }
                if (input[0] == "Spam" )
                {
                    

                    list.AddRange(input);
                    string spam = input[0];
                    if (list.Contains(spam))
                    {
                        list.Remove(spam);

                    }
                    
                }


                command = Console.ReadLine();
            }
            
            String.Join(" ", list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

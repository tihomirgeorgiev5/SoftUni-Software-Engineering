using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> followers =
                 new Dictionary<string, int[]>();
            string command = Console.ReadLine();


            while (true)
            {
                if (command == "Log out")
                {
                    break;
                }
                string[] commandArg = command.Split(": ");
                string currentCommand = commandArg[0];
                string username = commandArg[1];

                switch (currentCommand)
                {
                    case "New follower":
                        if (!followers.ContainsKey(username))
                        {
                            followers.Add(username, new int[2] { 0, 0 });
                        }

                        break;
                    case "Like":
                        int countLikes = int.Parse(commandArg[2]);
                        if (!followers.ContainsKey(username))
                        {
                            followers.Add(username, new int[2] { countLikes, 0 });
                        }
                        else
                        {
                            followers[username][0] += countLikes;
                        }

                        break;
                    case "Comment":
                        if (!followers.ContainsKey(username))
                        {
                            followers.Add(username, new int[2] { 0, 1 });
                        }
                        else
                        {
                            followers[username][1]++;
                        }

                        break;
                    case "Blocked":
                        if (!followers.ContainsKey(username))
                        {
                            Console.WriteLine($"{username} doesn't exist.");
                        }
                        else
                        {
                            followers.Remove(username);
                        }
                        break;
                    default:
                        break;
                }







                command = Console.ReadLine();
            }

            Console.WriteLine($"{followers.Count} followers");

            followers = followers.OrderByDescending(f => f.Value[0])
                .ThenBy(f => f.Key)
                .ToDictionary(f => f.Key, f => f.Value);

            foreach (var follower in followers)
            {
                Console.WriteLine($"{follower.Key}: {follower.Value[0] + follower.Value[1]}");
            }
        }
    }
}

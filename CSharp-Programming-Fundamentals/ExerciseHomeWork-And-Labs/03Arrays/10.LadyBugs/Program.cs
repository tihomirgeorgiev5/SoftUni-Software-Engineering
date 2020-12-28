using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] initialIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int currentIndex = initialIndexes[i];

                if(currentIndex >= 0 && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }
               
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] ellements = command.Split();
                int ladyBugIndex = int.Parse(ellements[0]);
                string direction = ellements[1];
                int flyLength = int.Parse(ellements[2]);

                if(ladyBugIndex < 0 || ladyBugIndex > field.Length -1 || field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                if(direction == "right")
                {
                    int landIndex = ladyBugIndex + flyLength;

                    if(landIndex > field.Length - 1)
                    {
                        continue;
                    }

                    if(field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            if(landIndex > field.Length - 1)
                            {
                                break;  
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }


                }
                else if(direction == "left")
                {
                    int landIndex = ladyBugIndex - flyLength;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                }
                  
            }
            Console.WriteLine(String.Join(" ",field));



        }
    }
}

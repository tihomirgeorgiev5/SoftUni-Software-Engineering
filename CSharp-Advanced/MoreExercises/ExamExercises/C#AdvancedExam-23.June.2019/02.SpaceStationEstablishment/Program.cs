using System;

namespace _02.SpaceStationEstablishment
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stephenRow = -1;
            int stephenCol = -1;

            char[][] matrix = new char[n][];

            for (int row = 0; row < n; row++)
            {
                matrix[row] = new char[n];
                char[] r = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    char ch = r[col];

                    if (ch == 'S')
                    {
                        stephenRow = row;
                        stephenCol = col;
                    }

                    matrix[row][col] = ch;
                }
            }

            int starCount = 0;

            while (true)
            {
                matrix[stephenRow][stephenCol] = '-';
                string command = Console.ReadLine();

                switch (command)
                {
                    case "right":
                        stephenCol += 1;    
                        break;
                    case "left":
                        stephenCol -= 1;
                        break;
                    case "up":
                        stephenRow -= 1;
                        break;
                    case "down":
                        stephenRow += 1;
                        break;

                    default:
                        break;
                }

               
                if (IsOutside(n, stephenRow, stephenCol))
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    break;
                }

                char element = matrix[stephenRow][stephenCol];

                if (element == 'O')
                {
                    matrix[stephenRow][stephenCol] = '-';

                    for (int row = 0; row < n; row++)
                    {
                        bool isFound = false;
                        for (int col = 0; col < n; col++)
                        {
                            char currElement = matrix[row][col];

                            if (currElement == 'O')
                            {
                                stephenRow = row;
                                stephenCol = col;

                                matrix[stephenRow][stephenCol] = 'S';

                                isFound = true;
                                 
                                break;
                            }
                        }

                        if (isFound)
                        {
                            break;
                        }
                    }

                }
                else if (char.IsDigit(element))
                {
                    starCount += element - '0';

                    if (starCount >= 50)
                    {
                        Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                        break;
                    }
                }
            }

            Console.WriteLine($"Star power collected: {starCount}");

            foreach (char[] col in matrix)
            {
                Console.WriteLine(string.Join("", col));
            }
            
        }

        private static bool IsOutside(int n, int stephenRow, int stephenCol)
        {
            return stephenRow >= n ||
                stephenRow < 0 ||
                stephenCol >= n ||
                stephenCol < 0;
        }
    }
}

using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int[,] numbers = new int[n, n];

                fillMatrix(numbers);
                //printMatrix(numbers);

                int sumD1 = 0;
                int sumD2 = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        int number = numbers[row, col];

                        if (row == col)
                        {
                            sumD1 += number;
                        }

                        if (col == n - 1 - row)
                        {
                            sumD2 += number;
                        }


                    }

                }
                Console.WriteLine(Math.Abs(sumD1 - sumD2));



            }

        private static void printMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        private static void fillMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split().Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = currentRow[col];
                }
            }
        }




    }

    
}

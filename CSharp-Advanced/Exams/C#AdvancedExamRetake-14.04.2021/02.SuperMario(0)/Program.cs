using System;
using System.Collections.Generic;

namespace _02.Super_Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            int mariosLives = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int marioRow = 0;
            int marioCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }
            string input = Console.ReadLine();

            while (mariosLives > 0)
            {

                matrix[marioRow, marioCol] = '-';
                marioRow = MoveRow(marioRow, input);
                marioCol = MoveCol(marioCol, input);

                if (IsOutside(marioRow, marioCol, n, n))
                {
                    mariosLives--;
                }

                if (matrix[marioRow, marioCol] == 'B')
                {
                    mariosLives -= 2;
                }

                input = Console.ReadLine();
            }



        }

        public static bool IsOutside(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }

        public static int MoveRow(int row, string movement)
        {
            if (movement == "W")
            {
                return row - 1;
            }
            if (movement == "S")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "A")
            {
                return col - 1;
            }
            if (movement == "D")
            {
                return col + 1;
            }
            HashSet<T>

           

            return col;
        }

    }
}

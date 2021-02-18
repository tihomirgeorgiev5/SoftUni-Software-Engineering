using System;
using System.Linq;

namespace _02.PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPresents = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

			char[,] matrix = new char[n, n];

			int santaRow = -1;
			int santaCol = -1;

			int countNiceKids = 0;



			for (int row = 0; row < n; row++)
			{
				char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
				for (int col = 0; col < currentRow.Length; col++)
				{
					matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'S')
                    {
						santaRow = row;
						santaCol = col;
                    }

                    if (matrix[row, col] == 'V')
                    {
						countNiceKids++;
                    }

					
				}
			}

			string command = Console.ReadLine();
			


			while (command != "Christmas morning")
			{
				
				matrix[santaRow, santaCol] = '-';
				
                switch (command)
                {
					case "up":
						santaRow--;
						break;
					case "down":
						santaRow++;
						break;
					case "left":
						santaCol--;
						break;
					case "right":
						santaCol++;
						break;

					default:
                        break;
                }

				if (matrix[santaRow, santaCol] == 'V')
                {
					
					countPresents--;
                }

				else if (matrix[santaRow, santaCol] == 'C')
				{
                    if (matrix[santaRow - 1, santaCol] != '-' )
                    {
						countPresents--;
						matrix[santaRow - 1, santaCol] = '-';


					}
					if (matrix[santaRow, santaCol - 1] != '-')
					{
						countPresents--;
						matrix[santaRow, santaCol - 1] = '-';


					}
					if (matrix[santaRow, santaCol + 1] != '-')
					{
						countPresents--;
						matrix[santaRow , santaCol + 1] = '-';


					}
					if (matrix[santaRow + 1, santaCol] != '-')
					{
						countPresents--;
						matrix[santaRow + 1, santaCol] = '-';


					}


				}
				if (countPresents <= 0)
				{
					Console.WriteLine("Santa ran out of presents!");
					break;
				}


				command = Console.ReadLine();

			}
			matrix[santaRow, santaCol] = 'S';



			int niceKidsWithNoPresent = 0;
			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
				{
					Console.Write(matrix[row, col] + " ");
					if (matrix[row, col] == 'V')
					{
						niceKidsWithNoPresent++;
					}
				}

				Console.WriteLine();
			}

			if (niceKidsWithNoPresent == 0)
            {
                Console.WriteLine($"Good job, Santa! {countNiceKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKidsWithNoPresent} nice kid/s.");
            }

			

		}

		
    }
}

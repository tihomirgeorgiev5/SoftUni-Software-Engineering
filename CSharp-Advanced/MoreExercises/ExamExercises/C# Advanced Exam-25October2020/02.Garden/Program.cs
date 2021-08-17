﻿using System;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(" ");
            int isRow = int.Parse(size[0]);
            int isCol = int.Parse(size[1]);
            int[,] garden = new int[isRow, isCol];

            for (int row = 0; row < isRow; row++)
            {
                for (int col = 0; col < isCol; col++)
                {
                    garden[row, col] = 0;
                }

            }

            while (true)
            {
                string tokens = Console.ReadLine();
                if (tokens == "Bloom Bloom Plow")
                {
                    break;
                }

                int row = int.Parse(tokens[0].ToString());
                int col = int.Parse(tokens[2].ToString());

                if (row < 0 || row > garden.GetLength(0) && 
                    col < 0 || col > garden.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                for (int i = 0; i < garden.GetLength(0); i++)
                {
                    garden[row, i]++;

                }
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    garden[j, col]++;
                }

                garden[row, col]--;
            }

            for (int row = 0; row < isRow; row++)
            {
                for (int col = 0; col < isCol; col++)
                {
                    Console.Write(garden[row, col] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

           //1 2 2 4 2 2 2 9
           //4 2

            int bombNum = bombInfo[0];
            int power = bombInfo[1];

            int bombIndex = list.IndexOf(bombNum);

            while (bombIndex != -1)
            {
                int leftNum = bombIndex - power;
                int rightNum = bombIndex + power;

                if (leftNum < 0)
                {
                    leftNum = 0;
                }
                if (rightNum > list.Count-1)
                {
                    rightNum = list.Count - 1;
                }

                list.RemoveRange(leftNum, rightNum - leftNum + 1);

                bombIndex = list.IndexOf(bombNum);
            }

            


            int sum = list.Sum();
                Console.WriteLine(sum);
            



            


        }
    }
}

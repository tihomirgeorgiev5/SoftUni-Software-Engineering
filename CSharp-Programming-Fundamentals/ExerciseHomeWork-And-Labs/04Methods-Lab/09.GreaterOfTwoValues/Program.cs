﻿using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type == "int")
            {
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(input1,input2));
            }
            if (type == "char")
            {
                char input1 = char.Parse(Console.ReadLine());
                char input2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(input1, input2));
            }
            if (type == "string")
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                Console.WriteLine(GetBigger(input1, input2));
            }



        }
        static string GetBigger(string input1, string input2)
        {
            int compare = input1.CompareTo(input2);
            if (compare > 0)
            {
                return input1;
            }
            else
            {
                return input2;
            }
        }
        static char GetBigger(char input1, char input2)
        {
            int compare = input1.CompareTo(input2);
            if (compare > 0)
            {
                return input1;
            }
            else
            {
                return input2;
            }
        }
       
        static int GetBigger(int input1, int  input2)
        {
            int compare = input1.CompareTo(input2);
            if (compare > 0)
            {
                return input1;
            }
            else
            {
                return input2;
            }
        }
    }
}

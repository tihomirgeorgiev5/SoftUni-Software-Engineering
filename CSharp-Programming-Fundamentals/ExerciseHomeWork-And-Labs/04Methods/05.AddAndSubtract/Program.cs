using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(firstNum, secondNum, thirdNum));

        }
        static int Sum(int a, int b, int c)
        {
            return a + b;
        }
        static int Subtract(int a, int b, int c)
        {
            return Sum(a,b,c) - c;
        }

    }
}

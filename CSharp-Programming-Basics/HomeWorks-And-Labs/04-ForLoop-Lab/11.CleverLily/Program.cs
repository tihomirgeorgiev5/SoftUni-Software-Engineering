using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toysCounter = 0;
            double savedMoney = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += i * 5;
                    savedMoney--;
                    //even
                }
                else 
                {
                    toysCounter ++;
                    //odd
                }
            }
            savedMoney += toysCounter * toyPrice;
            if (savedMoney >= washingMachine)
            {
                double diff = savedMoney - washingMachine;
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else 
            {
                double diff = washingMachine - savedMoney;
                Console.WriteLine ($" No! {diff:f2}");
            }
        }
    }
}

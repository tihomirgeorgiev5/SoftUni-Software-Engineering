using System;

namespace _01._Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата три числа b1, b2 и h и
            //пресмята лицето на трапец с основи b1 и b2 и височина h. 
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());


            //Формулата за лице на трапец е (b1 + b2) * h / 2.
            double liceTrapec = (b1 + b2) * h / 2.0;
            Console.WriteLine($"{liceTrapec:f2}");


             //На фигурата по - долу е показан трапец със страни 8 и 13 и височина 7.
             //Той има лице(8 + 13) *7 / 2 = 73.5.


        }
    }
}

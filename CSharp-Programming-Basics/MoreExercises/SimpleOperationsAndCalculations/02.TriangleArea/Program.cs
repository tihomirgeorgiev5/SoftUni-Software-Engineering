using System;

namespace _02._Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата страна и височина на триъгълник
            //и пресмята неговото лице.
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double areaTriangle = (a * h) / 2.0;
            Console.WriteLine($"{areaTriangle:f2}");
           
            //Използвайте формулата за лице на триъгълник: area = a * h / 2.
            //Форматирате изхода до втория знак след десетичната запетая.

        }
    }
}

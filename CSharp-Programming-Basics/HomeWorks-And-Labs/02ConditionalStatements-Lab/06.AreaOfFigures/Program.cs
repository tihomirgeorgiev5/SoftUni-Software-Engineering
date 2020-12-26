using System;
using System.Reflection.Metadata.Ecma335;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0;
            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
               

            }
            else if (figureType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
               



            }
            else if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = (side * height) / 2;
                
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}

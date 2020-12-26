using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат 2 числа, по едно на ред: w (дължина в метри)
            //и h (широчина в метри).
            double lenghtWMetres = double.Parse(Console.ReadLine());
            double widthHMetres = double.Parse(Console.ReadLine());
            int losesPlaces = 3;
            double biuraShirinaInCm = (widthHMetres * 100) - 100;
            double hPlaceForTables = Math.Floor(biuraShirinaInCm / 70);

            double biuraDulzhinaInCm = (lenghtWMetres * 100);
            double wPlaceForTables = Math.Floor(biuraDulzhinaInCm / 120);
            double tables = (hPlaceForTables * wPlaceForTables) - losesPlaces;
            Console.WriteLine(tables);
            
            //Ограничения: 3 ≤ h ≤ w ≤ 100.
           



        }
    }
}

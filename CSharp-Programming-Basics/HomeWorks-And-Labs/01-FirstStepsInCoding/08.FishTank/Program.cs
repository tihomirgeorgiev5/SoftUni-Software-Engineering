using System;

namespace _8.Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            // ⦁	Дължина в см – цяло число в интервала[10 … 500]

            //⦁	Широчина в см – цяло число в интервала[10 … 300]
            //⦁	Височина в см – цяло число в интервала[10… 200]
            //⦁	Процент  – реално число в интервала[0.000 … 100.000]
            int aquaLenght = int.Parse(Console.ReadLine());
            int aquaWidth = int.Parse(Console.ReadLine());
            int aquaHeight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            //Изчисляваме обем на аквариум:обем на аквариум = 85 * 75 * 47 = 299625 см3
            int volume = aquaHeight * aquaLenght * aquaWidth;
            //общо литри, които ще събере: 299625 * 0.001 = 299.625 литра
            double volumeInLiters = volume * 0.001;

            //процент: 17 * 0.01 = 0.17
            double calculatePercent = percent * 0.01;

            //литрите, които реално ще трябват : 299.625 * (1 - 0.17) = 248.68875 литра
            double result = volumeInLiters * (1 - calculatePercent);
            Console.WriteLine(result);



        }
    }
}

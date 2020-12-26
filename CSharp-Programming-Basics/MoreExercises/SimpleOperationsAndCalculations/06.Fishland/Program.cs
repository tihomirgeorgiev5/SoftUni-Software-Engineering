using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            //⦁	Първи ред – цена на скумрията на килограм. Реално число в интервала [0.00…40.00]
            double priceSkumriqKg = double.Parse(Console.ReadLine());
            //⦁	Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            double priceCacaKg = double.Parse(Console.ReadLine());
            //⦁	Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            double countPalamudKg = double.Parse(Console.ReadLine());
            //⦁	Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            double countSafridKg = double.Parse(Console.ReadLine());
            //⦁	Пети ред – килограма миди. Цяло число в интервала[0... 100]
            int countMidiKg = int.Parse(Console.ReadLine());

            // ⦁	Паламуд – 60 % по - скъп от скумрията
            double pricePalamudKg = priceSkumriqKg + (priceSkumriqKg * 0.6);
            //⦁	Сафрид – 80 % по - скъп от цацата
            double priceSafridKg = priceCacaKg + (priceCacaKg * 0.8);
            //⦁	Миди – 7.50 лв.за килограм
            double priceMidiKg = 7.5;

            double priceTotalMidi = priceMidiKg * countMidiKg;
            double priceTotalSafrid = priceSafridKg * countSafridKg;
            double priceTotalPalamud = pricePalamudKg * countPalamudKg;

            double total = priceTotalMidi + priceTotalPalamud + priceTotalSafrid;


            Console.WriteLine($"{total:f2}"); 


        }
    }
}

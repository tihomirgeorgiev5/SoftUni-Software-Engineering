using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBeerKegs = int.Parse(Console.ReadLine());
            float biggestKeg = float.MinValue;
            string nameOfBigKeg = string.Empty;

            for (int i = 0; i < countBeerKegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float volume = (float)( Math.PI * Math.Pow(radius, 2) * height);

                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    nameOfBigKeg = model;

                }


            }
            Console.WriteLine(nameOfBigKeg);
        }
    }
}

using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWagons = int.Parse(Console.ReadLine());
            int[] people = new int[countWagons];
            int sum = 0;


              for (int i = 0; i < countWagons; i++)
              {
                  people[i] = int.Parse(Console.ReadLine());
                  int currentPeople = people[i];
                  sum += currentPeople;
                  Console.Write($"{currentPeople} ");
              }
              Console.WriteLine();
              Console.WriteLine(sum);

           








        }
    }
}

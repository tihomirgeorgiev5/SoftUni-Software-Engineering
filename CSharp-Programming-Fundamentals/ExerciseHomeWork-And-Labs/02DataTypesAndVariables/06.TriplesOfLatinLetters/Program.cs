using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        char firstChar = (char)(97 + i);
                        char secondChar = (char)(97 + j);
                        char thirdChar = (char)(97 + k);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }

                }

            }
        }
    }
}

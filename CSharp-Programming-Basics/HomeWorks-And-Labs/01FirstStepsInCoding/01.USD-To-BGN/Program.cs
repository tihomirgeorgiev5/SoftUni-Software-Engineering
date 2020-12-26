using System;

namespace USDKumBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //прочитаме входа
            double input = double.Parse(Console.ReadLine());
            //изчисляваме курса
            double result = input * 1.79549;
            //принтираме резултата
            Console.WriteLine(result);

        }
    }
}

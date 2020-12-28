using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char sym1 = char.Parse(Console.ReadLine());
            char sym2 = char.Parse(Console.ReadLine());
            RangeOfChar(sym1, sym2);

        }
        static void RangeOfChar(char sym1, char sym2)
        {
            if (sym1 < sym2)
            {
                for (int i = sym1 + 1; i < sym2; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else if(sym1 > sym2)
            {
                for (int i = sym2; i < sym1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}

using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            //char a = 'a';
            //char b = 'z';
            //char c = 'A';
            //char d = 'Z';
            //
            //Console.WriteLine((int)a);
            //Console.WriteLine((int)b);
            //Console.WriteLine((int)c);
            //Console.WriteLine((int)d);

            char a = char.Parse(Console.ReadLine());
           

            int aCh = (int)a;
            

            if (aCh >= 97 && aCh <= 122)
            {
                Console.WriteLine("lower-case");
            }
            else if (aCh >= 65 && aCh <= 90)
            {
                Console.WriteLine("upper-case");
            }
        }

    }
}

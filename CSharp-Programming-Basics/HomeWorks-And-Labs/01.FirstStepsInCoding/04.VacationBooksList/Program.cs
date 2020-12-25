using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // ⦁	Брой страници в текущата книга – цяло число в интервала[1…1000];
            int stranici = int.Parse(Console.ReadLine());
            // ⦁	Страници, които може да прочита за 1 час – 
            //        реално число в интервала[1.00…1000.00];
            double straniciChas = double.Parse(Console.ReadLine());

            // ⦁	Броя на дните, за които трябва да прочете книгата – 
            //       цяло число в интервала[1…1000];
            int broiDni = int.Parse(Console.ReadLine());

            //1.изчисляваме общото време за четене на книгата: 212 / 20 = 10.6 часа
            double timeTotal = stranici / straniciChas;
            //2.получения резултат делим на броя дни, 
            //      за да получим необходимите часове на ден: 
            //      10.6 часа / 2 дни = 5.3 часа на ден
            double result = timeTotal / broiDni;
            Console.WriteLine(result);



        }
    }
}

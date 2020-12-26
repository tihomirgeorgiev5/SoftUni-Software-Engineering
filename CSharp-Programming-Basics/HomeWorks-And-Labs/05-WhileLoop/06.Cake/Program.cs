using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Поканени сте на 30 - ти рожден ден, на който рожденикът черпи с огромна торта.
            //Той обаче не знае колко парчета могат да си вземат гостите от нея
            //.Вашата задача е да напишете програма,
            //която изчислява броя на парчетата, които гостите са взели,
            //преди тя да свърши.
            //Ще получите размерите на тортата(широчина и дължина – цели числа в интервала[1...1000])
            //и след това на всеки ред, до получаване на командата "STOP" 
            //или докато не свърши тортата, 
            //броят на парчетата, които гостите вземат от нея.
            // Бележка: Едно парче торта е с размер 1х1 см.
            // Да се отпечата на конзолата един от следните редове:
            // ⦁	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
            // ⦁	"No more cake left! You need {брой недостигащи парчета} pieces more."

            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());

            int cakeTotalSize = cakeLenght * cakeWidth;
            int slicesCount = 0;
            string command = Console.ReadLine();

            while (command != "STOP")
            {
                int cakeSlice = int.Parse(command);
                cakeTotalSize -= cakeSlice;
               

                

                if (cakeTotalSize <= 0)
                {
                    break;
                }

                command = Console.ReadLine();


            }
            string result = "";

            if (cakeTotalSize > 0)
            {
                result = $"{cakeTotalSize} pieces are left.";
            }
            else
            {
                result = $"No more cake left! You need {Math.Abs(cakeTotalSize)} pieces more.";
            }

            Console.WriteLine(result);

           

        }
    }
}

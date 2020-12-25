using System;

namespace KalkulatorDepozit
{
    class Program
    {
        static void Main(string[] args)
        {
            //прочитаме входа
            double deposit = double.Parse(Console.ReadLine());
            int depositLenght = int.Parse(Console.ReadLine());
            double anualInterest = double.Parse(Console.ReadLine());


            //изчисляваме натрупаната лихва: 200 * 5.7 % = 11.4лв
            double acumulatedInterest = (deposit * anualInterest) / 100;
            //изчисляваме лихвата за 1 месец: 11.4лв./ 12 месеца = 0.95лв
            double interes = acumulatedInterest / 12;

            //общата сума е 200лв депозит +(3(срок на депозита) * 0.95 лв)
            double result = deposit + (depositLenght * interes);
            Console.WriteLine(result);
        }
    }
}

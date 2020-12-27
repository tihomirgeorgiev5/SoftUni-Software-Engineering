using System;

namespace SavingMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double sumPrivate = double.Parse(Console.ReadLine());

            double sumUnexp = 0.30 * income;
            double sumSavePerMonth = income - sumPrivate - sumUnexp;
            double percent = sumSavePerMonth / income * 100;
            double totalMoney = sumSavePerMonth * months;

            Console.WriteLine($"She can save {percent:f2}%");
            Console.WriteLine($"{totalMoney:f2}");

        }
    }
}

using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalExpences = 0;

            double moneyHeadset = headsetPrice * (Math.Floor (lostGamesCount*1.0 / 2));
            totalExpences += moneyHeadset;

            double moneyMouse = mousePrice * (Math.Floor (lostGamesCount * 1.0 / 3));
            totalExpences += moneyMouse;
            double moneyKeyboard = keyboardPrice * (Math.Floor(lostGamesCount * 1.0 / 6));
            totalExpences += moneyKeyboard;
            double moneyDisplay = displayPrice * (Math.Floor(lostGamesCount * 1.0 / 12));
            totalExpences += moneyDisplay;

            Console.WriteLine($"Rage expenses: {totalExpences:f2} lv.");

        }
    }
}

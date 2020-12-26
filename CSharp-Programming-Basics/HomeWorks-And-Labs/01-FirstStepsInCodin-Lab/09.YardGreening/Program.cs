using System;
using System.Reflection.Metadata.Ecma335;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
         
        {
            // read Yard
            //calculate price without discount (* 7.61)
            //calculate discount (priceWithoutDiscount * 0.18)
            //subtract discount from priceWithoutDiscount
            //The final price is: 3432.11 lv.
            //The discount is: 753.39 lv.

            double yard = double.Parse(Console.ReadLine());
            double priceWithoutDiscount = yard * 7.61;
            double discount = priceWithoutDiscount * 0.18;
            double finalPrice = priceWithoutDiscount - discount;

            Console.WriteLine(finalPrice);
            Console.WriteLine(discount);

        }
    }
}

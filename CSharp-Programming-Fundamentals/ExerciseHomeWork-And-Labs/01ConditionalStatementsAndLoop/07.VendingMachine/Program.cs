using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenMoney = Console.ReadLine();
            double sumCurrentCoins = 0;

            while (givenMoney!= "Start")
            {
                double currentCoin = double.Parse(givenMoney);

                if (currentCoin == 0.1 || currentCoin == 0.2|| currentCoin == 0.5||
                    currentCoin == 1|| currentCoin== 2)
                   {
                    sumCurrentCoins += currentCoin;
                  
                   }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }
                   

                givenMoney = Console.ReadLine();
            }
            // “Nuts”, “Water”, “Crisps”, “Soda”, “Coke”.
            // 2.0,     0.7,       1.5,     0.8,    1.0
            string product = Console.ReadLine();
            
            while (product != "End")
            {
                double priceProduct = 0;

                switch (product)
                {
                    case "Nuts":
                        priceProduct = 2.0;
                        break;
                    case "Water":
                        priceProduct = 0.7;
                        break;
                    case "Crisps":
                        priceProduct = 1.5;
                        break;
                    case "Soda":
                        priceProduct = 0.8;
                        break;
                    case "Coke":
                        priceProduct = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                        
                }
                if (sumCurrentCoins >= priceProduct)
                {
                    
                    sumCurrentCoins -= priceProduct;
                    Console.WriteLine($"Purchased { product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumCurrentCoins:f2}");


        }
    }
}

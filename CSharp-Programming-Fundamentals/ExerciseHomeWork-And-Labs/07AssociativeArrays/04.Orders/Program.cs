using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> dict = new Dictionary<string, Product>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] splittedInput = input.Split();
                string name = splittedInput[0];
                double price = double.Parse(splittedInput[1]);
                int quantity = int.Parse(splittedInput[2]);

                Product product = new Product(name, price, quantity);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, product);
                }
                else
                {
                    dict[name].Price = price;
                    dict[name].Quantity += quantity;
                    
                }

            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value.Price * pair.Value.Quantity :f2}");
            }
        }
    }
    class Product
    {
        string name;
        double price;
        int quantity;

        public Product (string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
    }
}

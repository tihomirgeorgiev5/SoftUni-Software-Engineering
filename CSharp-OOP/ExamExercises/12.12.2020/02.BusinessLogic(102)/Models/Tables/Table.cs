﻿
using Bakery.Models.BakedFoods.Contracts;

using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private List<IBakedFood> bakedFoods;
        private List<IDrink> drinks;
        private int capacity;
        private int numberOfPeople;

        public Table(int tableNumber, int capacity,  decimal pricePerPerson)
        {
            TableNumber = tableNumber;
            Capacity = capacity; 
            PricePerPerson = pricePerPerson;
            bakedFoods = new List<IBakedFood>();
            drinks = new List<IDrink>();
        }

        public int TableNumber { get; private set; }


        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTableCapacity);
                }
                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return this.numberOfPeople;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfPeople);
                }
                this.numberOfPeople = value;
            }
        }

        public decimal PricePerPerson { get; private set; }
           

        public bool IsReserved { get; private set; }

        public decimal Price 
        {
            get
            {
                return PricePerPerson * NumberOfPeople;
            }
            private set
            {

            }
    
        }

        public void Reserve(int numberOfPeople)
        {
            IsReserved = true;
            NumberOfPeople = numberOfPeople;
        }

        public void OrderFood(IBakedFood food)
        {
            this.bakedFoods.Add(food);
        }
       
        

        public void OrderDrink(IDrink drink)
        {
            this.drinks.Add(drink);
        }

        public decimal GetBill()
        {
            decimal bill = 0;

            foreach (var food in bakedFoods)
            {
                bill += food.Price;
            }

            foreach (var drink in drinks)
            {
                bill += drink.Price;
            }
            return bill;
        }

        public void Clear()
        {
            bakedFoods.Clear();
            drinks.Clear();
            numberOfPeople = 0;
            IsReserved = false;
        }

        string ITable.GetFreeTableInfo()
        {
            return $"Table: {TableNumber}\r\n" +
            $"Type: {this.GetType().Name}\r\n" +
            $"Capacity: {Capacity}\r\n" +
            $"Price per Person: {PricePerPerson}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        protected Animal(
            string name,
            double weight,
            //double foodEaten,
            HashSet<string> allowedFoods,
            double weightMidifier)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
           
            AllowedFoods = allowedFoods;
            WeightModifier = weightMidifier;
        }

        private HashSet<string> AllowedFoods { get; set; }

        private double WeightModifier { get; set; }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten{ get; private set; }


        public abstract string ProduceSound();

        public void Eat(Food food)
        {
            string foodTypeName = food.GetType().Name;
            if (!AllowedFoods.Contains(foodTypeName))
            {
                throw new InvalidOperationException($"{GetType().Name} does not eat {foodTypeName}!");
            }

            this.FoodEaten += food.Quantity;

            Weight += WeightModifier * food.Quantity;

        }
    }
}

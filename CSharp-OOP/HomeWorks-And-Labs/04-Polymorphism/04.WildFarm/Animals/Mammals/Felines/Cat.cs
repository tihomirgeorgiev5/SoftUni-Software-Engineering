﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {

        private const double BaseWeightModifier = 0.30;

        private static HashSet<string> allowedFoods =
            new HashSet<string>
            {

                nameof(Meat),
                nameof(Vegetable),

            };
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight,  allowedFoods, BaseWeightModifier, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

       
    }
}

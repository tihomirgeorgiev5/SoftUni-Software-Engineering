using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> ingredients;
       

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            this.ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel { get { return ingredients.Count; } }

        public void Add(Ingredient ingredient)
        {
            if (ingredients.Count < Capacity)
            {
                ingredients.Add(ingredient);
            }
        }
        public bool Remove(string name)
        {
            Ingredient ingredient = ingredients.FirstOrDefault(i => i.Name == name);
            if (ingredient == null)
            {
                return false;
            }
            ingredients.Remove(ingredient);
            return true;
        }

        public Ingredient FindIngredient(string name)
        {
            for (int i = 0; i < ingredients.Count; i++)
            {
                if (ingredients[i].Name == name)
                {
                    Ingredient ingredient = ingredients.FirstOrDefault(i => i.Name == name);

                    

                }
            }
           
            return null;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            return ingredients.OrderByDescending(i => i.Alcohol).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Cocktail: {Name} - Current Alcohol Level:");
            result.AppendLine($"{ingredients.Count}");

            foreach (var ingredient in ingredients)
            {
                result.AppendLine($"{ingredients}");
            }
            return result.ToString().TrimEnd();
        }



    }
}

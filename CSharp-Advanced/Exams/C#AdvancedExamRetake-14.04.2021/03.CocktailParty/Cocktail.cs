using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {

        private List<Ingredient> Ingredients;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
            this.Ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel { get { return Ingredients.Sum(i => i.Alcohol); } }

        public void Add(Ingredient ingredient)
        {
            if (!Ingredients.Any(i => i.Name == ingredient.Name) && (Ingredients.Count < Capacity) && ingredient.Alcohol <= MaxAlcoholLevel)
            {
                Ingredients.Add(ingredient);

            }
        }
        public bool Remove(string name)
        {
            var ingredientToRemove = Ingredients.FirstOrDefault(i => i.Name == name);

            if (ingredientToRemove == null)
            {
                return false;
            }

            Ingredients.Remove(ingredientToRemove);
            return true;
        }

        public Ingredient FindIngredient(string name)
        {
            var ingredient = Ingredients.FirstOrDefault(i => i.Name == name);

            return ingredient;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            var mostAlcoholic = Ingredients.OrderByDescending(i => i.Alcohol).FirstOrDefault();

            return mostAlcoholic;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            

            foreach (var ingredi in Ingredients)
            {
                sb.AppendLine(ingredi.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}

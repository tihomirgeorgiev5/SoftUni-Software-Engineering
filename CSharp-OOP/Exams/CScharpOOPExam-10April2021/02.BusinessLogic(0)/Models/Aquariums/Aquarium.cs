using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private readonly ICollection<IDecoration> decorations;
        private readonly ICollection<IFish> fish;

        protected Aquarium(int capacity, string name)
        {

            this.Name = name;
            this.Capacity = capacity;
            this.decorations = new List<IDecoration>();
            this.fish = new List<IFish>();
        }

        public string Name
        {
            get
            {
                return this.name;

            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);
                }
                this.name = value;
            }
        }
        public int Capacity { get; private set; }
        public int Comfort
        {
            get
            {
                return this.Decorations.Sum(d => d.Comfort);

            }
            private set
            {

            }
        }




        public ICollection<IDecoration> Decorations
        {
            get
            {
                return this.decorations.ToList().AsReadOnly();

            }
            private set
            {

            }
        }


        public ICollection<IFish> Fish
        {
            get
            {
                return this.fish.ToList().AsReadOnly();

            }
            private set
            {

            }
        }

        public void AddDecoration(IDecoration decoration)
            => this.decorations.Add(decoration);
        

        public void AddFish(IFish fish)
        {
            if (this.Fish.Count > this.Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }

            this.fish.Add(fish);
        }

        public void Feed()
        {
            foreach (var fish in Fish)
            {
                fish.Eat();
            }
        }

        public string GetInfo()

        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name} ({this.GetType().Name}):");

            if (this.Fish.Count == 0)
            {
                sb.AppendLine("Fish: none");
            }
            else
            {
                sb.AppendLine($"Fish: {string.Join(", ", this.Fish.Select(f => f.Name))}");
            }

            sb.AppendLine($"Decorations: {this.Decorations.Count}");
            sb.AppendLine($"Comfort: {this.Comfort}");

            return sb.ToString().TrimEnd();

        }

        public bool RemoveFish(IFish fish)
            => Fish.Remove(fish);
            
        

        //public void AddDecoration(IDecoration decoration);
        //public void AddFish(IFish fish);
        //public void Feed();
        //public  string GetInfo();
        //public bool RemoveFish(IFish fish);
    }
}

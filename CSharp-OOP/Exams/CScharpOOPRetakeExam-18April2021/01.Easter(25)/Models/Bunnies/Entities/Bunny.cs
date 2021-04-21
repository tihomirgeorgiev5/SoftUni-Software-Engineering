using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Bunnies.Entities
{
    public abstract class Bunny : IBunny
    {
        private string name;
        private int energy;
        private List<IDye> data;
        private const int initialBunnyEnergy = 10;

        protected Bunny(string name, int energy)
        {
            this.Name = name;
            this.Energy = energy;
            this.data = new List<IDye>();
        }
            
        

        public  string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBunnyName);
                }
                this.name = value;

            }
                
        }
        public int Energy
        {
            get => this.energy;
       
            private set
            {
                if (this.energy < 0)
                {
                    this.energy = 0;
                }
                this.energy = value;
       
            }
        }



        public ICollection<IDye> Dyes => this.data.AsReadOnly();

        public void AddDye(IDye dye)
        {
            this.data.Add(dye);
        }

        public void Work()
        {
            if (this.energy < 0)
            {
                this.energy = 0;
            }
            this.energy -= initialBunnyEnergy;
        }
    }
}

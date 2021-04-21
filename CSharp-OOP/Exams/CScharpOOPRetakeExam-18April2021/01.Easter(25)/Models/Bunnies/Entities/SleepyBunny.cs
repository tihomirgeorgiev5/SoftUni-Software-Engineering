using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Bunnies.Entities
{
    public class SleepyBunny : Bunny
    {
        private const int initialEnergy = 50;
        private const int bunnyEnergy = 15;
        public SleepyBunny(string name) : base(name, initialEnergy)
        {
        }

        
    }
}

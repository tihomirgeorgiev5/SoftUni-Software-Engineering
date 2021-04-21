using Easter.Models.Dyes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Dyes.Entities
{
    public class Dye : IDye
    {
        private int power;
        private const int powerDecrease = 10;

        public Dye(int power)
        {
            Power = power;
        }

        public int Power
        {
            get { return this.power; } 
            private set
            {
                if (this.power < 0)
                {
                    this.power = 0;
                }
            }
        }

        public bool IsFinished()
        {
            throw new NotImplementedException();
        }

        public void Use()
        {
            if (this.power < 0)
            {
                this.power = 0;
            }

            this.power -= powerDecrease;
        }
    }
}

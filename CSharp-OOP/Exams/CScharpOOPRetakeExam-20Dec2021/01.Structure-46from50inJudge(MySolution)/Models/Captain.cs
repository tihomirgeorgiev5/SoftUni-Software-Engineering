using NavalVessels.Models.Contracts;
using NavalVessels.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Captain : ICaptain
    {
        private string fullName;
        private int combatExperience = 0;
        private readonly List<IVessel> vessels;
        public Captain(string fullName)
        {
            this.FullName = fullName;
            this.vessels = new List<IVessel>();

        }
        public string FullName
        {

            get
            {
                return this.fullName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCaptainName);
                }
                this.fullName = value;
            }

        }

        public int CombatExperience => throw new NotImplementedException();

        public ICollection<IVessel> Vessels => throw new NotImplementedException();

        public void AddVessel(IVessel vessel)
        {
            throw new NotImplementedException();
        }

        public void IncreaseCombatExperience()
        {
            throw new NotImplementedException();
        }

        public string Report()
        {
            throw new NotImplementedException();
        }
    }
}

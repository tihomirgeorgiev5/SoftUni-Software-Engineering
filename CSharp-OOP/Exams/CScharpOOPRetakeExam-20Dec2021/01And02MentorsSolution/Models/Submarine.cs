using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Submarine : Vessel, ISubmarine
    {
        private static double initialArmorThickness = 200;

        public Submarine(string name, double mainWeaponCaliber, double speed) 
            : base(name, mainWeaponCaliber, speed, initialArmorThickness)
        {
            SubmergeMode = false;
        }

        public bool SubmergeMode { get; private set; }

        public void ToggleSubmergeMode()
        {
            if (SubmergeMode == true)
            {
                this.MainWeaponCaliber -= 40;
                this.Speed += 4;

                this.SubmergeMode = false;
            }
            else
            {
                this.MainWeaponCaliber += 40;
                this.Speed -= 4;

                this.SubmergeMode = true;
            }
        }

        public override void RepairVessel()
        {
            if (this.ArmorThickness < 200)
            {
                this.ArmorThickness = 200;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string submergeMode = this.SubmergeMode == true ? "ON" : "OFF";

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Submerge mode: {submergeMode}");

            return sb.ToString().TrimEnd();
        }
    }
}

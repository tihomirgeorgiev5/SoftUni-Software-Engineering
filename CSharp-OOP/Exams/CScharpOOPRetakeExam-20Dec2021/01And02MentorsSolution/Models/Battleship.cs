using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Battleship : Vessel, IBattleship
    {
        private static double initialArmorThickness = 300;

        public Battleship(string name, double mainWeaponCaliber, double speed) 
            : base(name, mainWeaponCaliber, speed, initialArmorThickness)
        {
            SonarMode = false;
        }

        public bool SonarMode { get; private set; }

        public void ToggleSonarMode()
        {
            if (SonarMode == true)
            {
                this.MainWeaponCaliber -= 40;
                this.Speed += 5;

                this.SonarMode = false;
            }
            else
            {
                this.MainWeaponCaliber += 40;
                this.Speed -= 5;

                this.SonarMode = true;
            }
        }

        public override void RepairVessel()
        {
            if (this.ArmorThickness < 300)
            {
                this.ArmorThickness = 300;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string sonarMode = this.SonarMode == true ? "ON" : "OFF";


            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Sonar mode: {sonarMode}");

            return sb.ToString().TrimEnd();
        }
    }
}

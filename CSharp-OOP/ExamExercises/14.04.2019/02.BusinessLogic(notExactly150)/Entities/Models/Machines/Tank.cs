using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities.Models.Machines
{
    public class Tank : BaseMachine, ITank
    {
        private const int initialHealthPoints = 100;
        public const int initialAttackPoints = 40;
        public const int initialDefensePoints = 30;
        private string tankName;

        public Tank(string name, double attackPoints, double defensePoints) : base(name, attackPoints, defensePoints, initialHealthPoints)
        {
            this.DefenseMode = true;
        }

        

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode == false)
            {
                this.DefenseMode = true;
                this.AttackPoints -= initialAttackPoints;
                this.DefensePoints += initialDefensePoints;
            }
            else
            {
                this.DefenseMode = false;
                this.AttackPoints += initialAttackPoints;
                this.DefensePoints -= initialDefensePoints;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Defence: {(this.DefenseMode == true ? "ON" : "OFF")}");

            return sb.ToString().TrimEnd();
        }
    }
}

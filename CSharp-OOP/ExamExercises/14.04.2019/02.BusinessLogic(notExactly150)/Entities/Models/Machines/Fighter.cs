using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities.Models.Machines
{
    public class Fighter : BaseMachine, IFighter
    {
        private const int inititalHealthPoints = 200;
        public const int initialAttackPoints = 50;
        public const int initialDefensePoints = 25;
        public Fighter(string name, double attackPoints, double defensePoints) : base(name, attackPoints, defensePoints, inititalHealthPoints)
        {
            this.AggressiveMode = true;
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if (this.AggressiveMode == false)
            {
                this.AggressiveMode = true;
                this.AttackPoints += initialAttackPoints;
                this.DefensePoints -= initialDefensePoints;
            }
            else
            {
                this.AggressiveMode = false;
                this.AttackPoints -= initialAttackPoints;
                this.DefensePoints += initialDefensePoints;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Aggressive: {(this.AggressiveMode == true ? "ON" : "OFF")}");

            return sb.ToString().TrimEnd();
        }

        public void ToggleFighterAggressiveMode()
        {
            throw new NotImplementedException();
        }
    }
}

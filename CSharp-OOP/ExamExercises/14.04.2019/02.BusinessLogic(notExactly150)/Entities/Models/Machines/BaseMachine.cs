using MortalEngines.Common;
using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities.Models.Machines


{
    public abstract class BaseMachine : IMachine
    {
        private string name;
        private IPilot pilot;
        
        public BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            Name = name;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
            HealthPoints = healthPoints;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.NullMachineName);
                }
            }
        }

        public double AttackPoints { get; set; }

        public double DefensePoints { get; set; }

        public double HealthPoints { get; set; }
        public IPilot Pilot
        {
            get => this.pilot;

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(ExceptionMessages.NullPilot);
                }
                this.pilot = value;
            }
        }

        public IList<string> Targets { get; private set; }

        public void Attack(IMachine target)
        {
            if (target == null)
            {
                throw new NullReferenceException(ExceptionMessages.NullTarget);
            }

            double difference = Math.Abs(this.AttackPoints - target.DefensePoints);

            if (target.HealthPoints - difference < 0)
            {
                target.HealthPoints = 0;
            }
            else
            {
                target.HealthPoints -= difference;
            }

            Targets.Add(target.Name);

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"- {Name}");
            sb.AppendLine($" *Type: {this.GetType().Name}");
            sb.AppendLine($" * Health: {this.HealthPoints}");
            sb.AppendLine($" * Attack: {this.AttackPoints}");
            sb.AppendLine($" *Defense: {this.DefensePoints}");

            if (Targets.Count == 0)
            {
                sb.AppendLine(" *Targets: None");
            }
            else
            {
                sb.AppendLine($" *Targets: {string.Join(",", Targets)}");
            }

            return sb.ToString().TrimEnd();
           
        }
    }
}

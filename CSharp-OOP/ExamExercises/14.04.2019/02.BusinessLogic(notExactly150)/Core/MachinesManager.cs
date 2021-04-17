namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Common;
    using MortalEngines.Entities.Contracts;
    using MortalEngines.Entities.Models;
    using MortalEngines.Entities.Models.Machines;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private readonly List<IPilot> pilots;
        private readonly List<IMachine> machines;

        public MachinesManager()
        {
            this.pilots = new List<IPilot>(); ;
            this.machines = new List<IMachine>();
        }

        public string HirePilot(string name)
        {
            if (this.pilots.Any(p => p.Name == name))
            {
                return string.Format(OutputMessages.PilotExists, name);
            }

            IPilot pilot = new Pilot(name);
            this.pilots.Add(pilot);

            return string.Format(OutputMessages.PilotHired, pilot.Name);
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.Any(m => m.Name == name && m.GetType().Name == nameof(Tank)))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }
            ITank tank = new Tank(name, attackPoints, defensePoints);
            this.machines.Add(tank);

            return string.Format(OutputMessages.TankManufactured, tank.Name, tank.AttackPoints, tank.DefensePoints);
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.Any(m => m.Name == name && m.GetType().Name == nameof(Fighter)))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }
            IFighter fighter = new Fighter(name, attackPoints, defensePoints);
            this.machines.Add(fighter);

            return string.Format(OutputMessages.FighterManufactured, fighter.Name, fighter.AttackPoints, fighter.DefensePoints);
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            if (this.pilots.FirstOrDefault(p => p.Name== selectedPilotName) == null)
            {
                return string.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }
            if (this.machines.FirstOrDefault(m => m.Name == selectedMachineName)== null)
            {
                return string.Format(OutputMessages.MachineNotFound, selectedMachineName);
            }
            IPilot pilot = this.pilots.FirstOrDefault(p => p.Name == selectedPilotName);
            IMachine mashine = this.machines.FirstOrDefault(m => m.Name == selectedMachineName);

            if (mashine.Pilot != null)
            {
                return string.Format(OutputMessages.MachineHasPilotAlready, mashine.Name);

            }
            mashine.Pilot = pilot;
            pilot.AddMashine(mashine);

            return string.Format(OutputMessages.MachineEngaged, pilot.Name, mashine.Name);
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            if (this.machines.FirstOrDefault(m => m.Name == attackingMachineName) == null) 
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }
            if (this.machines.FirstOrDefault(m => m.Name == defendingMachineName) == null)
            {
                return string.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }
            IMachine attacker = this.machines.FirstOrDefault(m => m.Name == attackingMachineName);
            IMachine deffender = this.machines.FirstOrDefault(m => m.Name == defendingMachineName);

           // Searches for two machines by given names and the first /one /attacks the second one if both machines have health //higher than zero. 
           //
            if (attacker.HealthPoints <= 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attacker.Name);
            }
            if (deffender.HealthPoints <=0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, deffender.Name);
            }
            attacker.Attack(deffender);

            return string.Format(OutputMessages.AttackSuccessful, deffender.Name, attacker.Name, deffender.HealthPoints);
        }

        public string PilotReport(string pilotReporting)
        {
            return this.pilots.FirstOrDefault(p => p.Name == pilotReporting).Report();
        }

        public string MachineReport(string machineName)
        {
            return this.machines.FirstOrDefault(m => m.Name == machineName).ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if(this.machines.FirstOrDefault(m => m.Name == fighterName && m.GetType().Name == nameof(Fighter)) == null);
            {
                return string.Format(OutputMessages.MachineNotFound, fighterName);
            }

            IFighter fighter = (Fighter)this.machines.FirstOrDefault(m => m.Name == fighterName && m.GetType().Name == nameof(Fighter));
            fighter.ToggleFighterAggressiveMode();

            return string.Format(OutputMessages.FighterOperationSuccessful, fighter.Name);
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            if (this.machines.FirstOrDefault(m => m.Name == tankName && m.GetType().Name == nameof(Tank))== null);
            {
                return string.Format(OutputMessages.MachineNotFound, tankName);
            }

            ITank tank = (Tank)this.machines.FirstOrDefault(m => m.Name == tankName && m.GetType().Name == nameof(Tank));
            tank.ToggleDefenseMode();

            return string.Format(OutputMessages.TankOperationSuccessful, tank.Name);
        }
    }
}
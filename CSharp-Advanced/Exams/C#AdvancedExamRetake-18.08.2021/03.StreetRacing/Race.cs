using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        private List<Car> Participants;
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            this.Participants = new List<Car>();
        }
        public string Name { get; set; }

        public string Type { get; set; }

        public int Laps { get; set; }

        public int Capacity { get; set; }

        public int MaxHorsePower { get; set; }

        public int Count { get { return Participants.Count; } }

        public void Add(Car car)
        {
            if (!Participants.Any(p => p.LicensePlate == car.LicensePlate ) && Participants.Count < Capacity && car.HorsePower <= MaxHorsePower)
            {
                Participants.Add(car);
            }

        }
        public bool Remove(string licensePlate)
        {
            var carToRemove = Participants.FirstOrDefault(c => c.LicensePlate == licensePlate );

            if (carToRemove == null)
            {
                return false;
            }

            Participants.Remove(carToRemove);
            return true;
        }

        public Car FindParticipant(string licensePlate)
        {
            var car = Participants.FirstOrDefault(c => c.LicensePlate == licensePlate);


            return car;
        }

        public Car GetMostPowerfulCar()
        {
            return Participants.OrderByDescending(c => c.HorsePower).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");

            foreach (var race in Participants)
            {
                sb.AppendLine(race.ToString());

            }
            return sb.ToString().TrimEnd();
        }

    }
}

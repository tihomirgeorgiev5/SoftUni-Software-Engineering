using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StreetRacing
{
    public class Race
    {
        private List<Car> participants;

        public Race(string name, string type, int laps,
            int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            this.participants = new List<Car>();
        }

        public List<Car> Participants { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Laps { get; set; }

        public int Capacity { get; set; }

        public int MaxHorsePower { get; set; }

        public int Count { get { return participants.Count; } }

        public void Add(Car car)
        {
            
            if (this.Capacity > participants.Count
                && this.MaxHorsePower == car.HorsePower)
                
            {
                participants.Add(car);
               //if (participants.Where(c => c.LicensePlate != //car.LicensePlate)))
               //{
               //
               //}
            }
        }
        public bool Remove(string licensePlate)
        {
    
            Car car = participants.FirstOrDefault(c => c.LicensePlate == licensePlate);

            if (car == null)
            {
                return false;
            }
            participants.Remove(car);

            return true;
        }

        public Car FindParticipant(string licensePlate)
        {
            Car car = participants.FirstOrDefault(c => c.LicensePlate == licensePlate);

            if (participants.Contains(car))
            {
                return car; 
            }
            return null;
        }

        public Car GetMostPowerfulCar()
        {
            
            
            Car car = participants.OrderByDescending(c => c.HorsePower).First();
            if (participants.Count <= 0)
            {
                return null;
            }
            return car;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");

            foreach (var car in participants)
            {
                sb.AppendLine($"{car}");
            }

            return sb.ToString().TrimEnd();
        }


    }
}

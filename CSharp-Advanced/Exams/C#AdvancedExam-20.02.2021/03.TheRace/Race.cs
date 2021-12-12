using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Racer>();

        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        public void Add(Racer Racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(Racer);
                
            }
           
        }
        public bool Remove(string name)
        {
            var racerToRemove = data.FirstOrDefault(r => r.Name == name);
            if (racerToRemove == null)
            {
                return false;
            }
            data.Remove(racerToRemove);
            return true;
        }

        public Racer GetOldestRacer()
        {
            var racer = data.OrderByDescending(r => r.Age).FirstOrDefault();

            return racer;
        }

        public Racer GetRacer(string name)
        {
            var racer = data.FirstOrDefault(r => r.Name == name);

            return racer;
        }

        public Racer GetFastestRacer()
        {
            var fastestRacer = data.OrderByDescending(r => r.Car.Speed).FirstOrDefault();

            return fastestRacer;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Racers participating at {Name}:");

            foreach (var racer in data)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();
        }



    }
}

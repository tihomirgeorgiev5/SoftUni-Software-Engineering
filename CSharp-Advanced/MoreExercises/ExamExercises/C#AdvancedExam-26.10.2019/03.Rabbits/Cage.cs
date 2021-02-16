using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Rabbit>();

        }

        public string Name { get; set; }

        public int Capacity { get; set; }
        public Rabbit First { get; private set; }

        public int Count { get { return data.Count; } }

        public void Add(Rabbit rabbit)
        {
            if (data.Count < Capacity)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbitToRemove = data.FirstOrDefault(r => r.Name == name);

            if (rabbitToRemove != null)
            {
                data.Remove(rabbitToRemove);
                return true;
            }
            return false;
        }

        public void RemoveSpecies(string species)
        {
            data.RemoveAll(r => r.Species == species);
   
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Name == name);

            if (rabbit != null)
            {
                rabbit.Available = false;
            }
            return rabbit;
        }

        public Rabbit[] SellRabbitBySpecies(string species)
        {
            Rabbit[] rabbits = data.Where(r => r.Species == species).ToArray();

            foreach (var rabbit in rabbits)
            {
                rabbit.Available = false;
            }
            return rabbits;
        }

        public string report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at {Name}:");

            foreach (var rabbit in data.Where(r => r.Available))
            {
                sb.AppendLine(rabbit.ToString());
            }
            return sb.ToString().TrimEnd();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> data;
        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            data = new List<Present>();
        }

        public string Color { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        public void Add(Present present)
        {
            if (Count < Capacity)
            {
                data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            Present presentToRemove = data.FirstOrDefault(p => p.Name == name);
            if (presentToRemove != null)
            {
                data.Remove(presentToRemove);
                return true;
            }
            return false;
        }

        public Present GetHeaviestPresent()
        {
            Present heaviestPresent = data.OrderByDescending(p => p.Weight).FirstOrDefault();
            return heaviestPresent;
        }

        public Present GetPresent(string name)
        {
            Present present = data.FirstOrDefault(p => p.Name == name);
            return present;
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine($"{Color} bag contains:");

            foreach (var present in data)
            {
                report.AppendLine(present.ToString());
            }
            return report.ToString().TrimEnd();
        }





    }
}

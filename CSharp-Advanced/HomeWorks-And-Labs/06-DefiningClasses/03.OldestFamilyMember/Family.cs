using System;
using System.Collections.Generic;
using System.Text;

namespace OldestFamilyMember
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestPerson()
        {
            int maxAge = int.MinValue;
            Person person = null;

            foreach (var currentPerson in People)
            {
                var currentAge = currentPerson.Age;

                if (currentAge > maxAge)
                {
                    maxAge = currentAge;
                    person = currentPerson;
                }
            }
            return person;

           


        }
    }
}

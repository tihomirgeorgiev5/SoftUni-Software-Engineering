using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Pesho", 45);
            Console.WriteLine($"{person.Name} => {person.Age}");
        }
    }
}

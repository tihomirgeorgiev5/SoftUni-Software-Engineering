using System;
using System.Reflection;

namespace ReflectingConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Student);
            ConstructorInfo[] constructors = type.GetConstructors();

            foreach (var constructor in constructors)
            {
                
                Console.WriteLine(constructor);
            }
        }
    }
}

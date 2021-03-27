using System;
using System.Reflection;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Type studentType = typeof(Student);

            Type[] interfaces = studentType.GetInterfaces();

            foreach (var type in interfaces)
            {
                Console.WriteLine(type.Name);
            }

            MethodInfo[] methods = studentType.GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}

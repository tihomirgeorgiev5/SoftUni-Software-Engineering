using System;

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
        }
    }
}

﻿using System;
using System.Reflection;

namespace Reflection_NonPublic
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Type studentType = typeof(Student);

            FieldInfo[] fields = studentType.GetFields(
                
                BindingFlags.Static |
               
                BindingFlags.NonPublic);

            foreach (var field in fields)
            {
                Console.WriteLine(field.Name);
                Console.WriteLine(field.FieldType);
                Console.WriteLine($"Is public? {field.IsPublic}");

                Console.WriteLine("Accessing private data average grade: ");

                var grade = field.GetValue(student);

                Console.WriteLine($"{field.Name} : {grade}");
            }




        }
    }
}

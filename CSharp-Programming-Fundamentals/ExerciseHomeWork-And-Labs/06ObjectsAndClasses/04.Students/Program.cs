﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                var studentsInfo = Console.ReadLine()
                    .Split()
                    .ToArray();
                Student student = new Student(studentsInfo[0], studentsInfo[1], double.Parse(studentsInfo[2]));
                students.Add(student);

            }
            Console.WriteLine(string.Join(Environment.NewLine, students.OrderByDescending(x => x.Grade)));
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;

            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }

        }
    }
}

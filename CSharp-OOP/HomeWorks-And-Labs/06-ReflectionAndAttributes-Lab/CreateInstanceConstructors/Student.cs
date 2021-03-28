using System;
using System.Collections.Generic;
using System.Text;

namespace CreateInstanceConstructors
{
    public class Student
    {
        private int averageGrade = 2;
        private static int age = 15;
        internal string fullName = "Goro Ivanov";
        public string nickname = "pecheniq";

        public Student()
        {

        }

        public Student(string name, int x)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}

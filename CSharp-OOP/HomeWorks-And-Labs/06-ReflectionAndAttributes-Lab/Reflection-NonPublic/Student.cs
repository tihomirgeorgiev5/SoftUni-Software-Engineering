using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection_NonPublic
{
    class Student
    {
        private static int averageGrade = 2;
        private static int age = 15;
        internal string fullName = "Pesho Peshov";
        public string prqkor = "gotiniq";

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

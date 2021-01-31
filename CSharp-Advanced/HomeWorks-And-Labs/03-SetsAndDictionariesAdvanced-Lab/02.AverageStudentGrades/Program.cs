using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentGrades =
                new Dictionary<string, List<decimal>>();

            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal>());

                }
                studentGrades[name].Add(grade);
            }

            foreach (var student in studentGrades)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");


            }
            



        }
    }
}

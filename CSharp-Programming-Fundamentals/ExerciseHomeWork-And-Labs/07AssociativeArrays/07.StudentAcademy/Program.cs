using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades =
                new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string nameStudent = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(nameStudent))
                {
                    studentGrades.Add(nameStudent, new List<double>());
                    studentGrades[nameStudent].Add(grade);
                     
                }
                else
                {
                    studentGrades[nameStudent].Add(grade);
                }
            }
            Dictionary<string, double> averageGrade = 
                new Dictionary<string, double>();

            foreach (var pair in studentGrades)
            {
                averageGrade.Add(pair.Key, pair.Value.Average());

 
            }
            foreach (var item in averageGrade
                    .Where(student => student.Value >= 4.50)
                    .OrderByDescending(st => st.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}

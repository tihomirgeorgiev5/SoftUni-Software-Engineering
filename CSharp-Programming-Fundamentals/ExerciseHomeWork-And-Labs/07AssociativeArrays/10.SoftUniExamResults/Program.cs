﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> students =
                new Dictionary<string, int>();
            Dictionary<string, int> submissions =
                new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] comandArg = input.Split("-");
                string user = comandArg[0];

                if (comandArg.Length > 2)
                {
                    string language = comandArg[1];
                    int points = int.Parse(comandArg[2]);

                    if (!students.ContainsKey(user))
                    {
                        students.Add(user, points);
                    }
                    else
                    {
                        if (students[user] < points)
                        {
                            students[user] = points;
                        }
                    }
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                }
                else
                {
                    students.Remove(user);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results :");

            foreach (var currentStudent in students
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currentStudent.Key} | {currentStudent.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var currentSubmission in submissions
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currentSubmission.Key} - {currentSubmission.Value}");
            }
        }
    }
}

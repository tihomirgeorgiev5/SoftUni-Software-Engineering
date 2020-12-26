using System;
using System.Data;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Марин решава задачи от изпити
            //докато не получи съобщение "Enough" от лектора си.
            //При всяка решена задача той получава оценка.
            //Програмата трябва да приключи прочитането на данни при команда "Enough"
            //или ако Марин получи определения брой незадоволителни оценки.
            //Незадоволителна е всяка оценка, която е по-малка или равна на 4.

            // ⦁	На първи ред - брой незадоволителни оценки -цяло число 
            int failedThreshold = int.Parse(Console.ReadLine());
            // ⦁	След това многократно се четат по два реда:
            // ⦁	Име на задача - текст(низ)
            // ⦁	Оценка - цяло число в интервала[2…6]

            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (failedTimes < failedThreshold)
            {
                string problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradesSum += grade;
                solvedProblemsCount++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedProblemsCount :f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}"); 
            } 

            // ⦁	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда:
            // ⦁	"Average score: {средна оценка}"
            // ⦁	"Number of problems: {броя на всички задачи}"
            // ⦁	"Last problem: {името на последната задача}"
            // ⦁	Ако получи определеният брой незадоволителни оценки:
            // ⦁	"You need a break, {брой незадоволителни оценки} poor grades."
            // Средната оценка да бъде форматирана до втория знак след десетичната запетая.


        }
    }
}

using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());

            double studentsFinalAssessment = 0;
            int presentationsCount = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Finish")
                {
                    break;
                }

                presentationsCount++;
                double presentationAverage = 0;
                for (int i = 0; i < juryCount; i++)
                {
                    double juryGrade = double.Parse(Console.ReadLine());
                    presentationAverage += juryGrade;

                }
                presentationAverage /= juryCount;
                studentsFinalAssessment += presentationAverage;

                Console.WriteLine($"{input} - {presentationAverage:f2}.");

            }

            studentsFinalAssessment /= presentationsCount;

            Console.WriteLine($"Student's final assessment is {studentsFinalAssessment:f2}.");
        }
    }
}

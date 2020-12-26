using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int grade = 1;
            int failedCounter = 0;

            //graduation
            //suspended
            double totalRating = 0;

            while (grade <= 12) 
            {
                double rating = double.Parse(Console.ReadLine());

                if (rating >= 4)
                {
                    totalRating += rating;
                    grade++;
                }
                else
                {
                    failedCounter++;
                    if (failedCounter == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grade} grade");
                        break;
                    }

                }

                    

            }
            if (grade == 13)
            {
                double averageGrade = totalRating / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
            


        }
    }
}

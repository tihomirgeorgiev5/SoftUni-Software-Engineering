using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int bonusInitial = int.Parse(Console.ReadLine());

            double maxNum = 0;
            int studentAttended = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                
                int attendances = int.Parse(Console.ReadLine());

                //Print the maximum bonus points 
                //along with the attendances of the given student

                // "Max Bonus: {maxBonusPoints}."
                //"The student has attended {studentAttendances} lectures."

                //{total bonus} = {student attendances} /
                //{course lectures} *( 5 + { additional bonus})

                double totalBonus = attendances * 1.0 /
                lecturesCount * (5 + bonusInitial);

                if (totalBonus > maxNum)
                {
                    maxNum = totalBonus;
                    studentAttended = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxNum)}.");
            Console.WriteLine($"The student has attended {studentAttended} lectures.");
        }
    }
}

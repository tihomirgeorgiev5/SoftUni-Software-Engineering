using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minIncome = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minIncome * 0.35);
            double highGradeScholarship = Math.Floor(grade * 25);

            //	Ако ученикът няма право да получава стипендия, се извежда:
                //"You cannot get a scholarship!"
            //Ако ученикът има право да получава само социална стипендия:
                //"You get a Social scholarship {стойност на стипендия} BGN"
            //Ако ученикът има право да получава само стипендия за отличен успех:
                //"You get a scholarship for excellent results {стойност на стипендията} BGN"
            //Ако ученикът има право да получава и двата типа стипендии,
                //ще получи по-голямата по сума, а ако са равни ще получи тази за отличен успех.

            string highGrade = "";

            if (grade >= 5.50 && income <= minIncome && highGradeScholarship >= socialScholarship)
            {
                highGrade = $"You get a scholarship for excellent results {highGradeScholarship} BGN";
            }
            else if (grade >= 5.50 && income > minIncome)
            {
                highGrade = $"You get a scholarship for excellent results {highGradeScholarship} BGN";
            }
            else if (income <= minIncome && grade >= 5.50 && highGradeScholarship < socialScholarship)
            {
                highGrade = $"You get a Social scholarship {socialScholarship} BGN";
            }
            else if (income <= minIncome && grade > 4.50)
            {
                highGrade = $"You get a Social scholarship {socialScholarship} BGN";
            }
            else
            {
                highGrade = $"You cannot get a scholarship!";
            }
            Console.WriteLine(highGrade);
        }
    }
}

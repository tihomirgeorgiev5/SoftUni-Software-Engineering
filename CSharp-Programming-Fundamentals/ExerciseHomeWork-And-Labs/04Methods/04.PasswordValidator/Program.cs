using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            CheckIfPassIsValid(pass);

        }
        static void CheckIfPassIsValid(string pass)
        {
            bool invalid = false;
            if(pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;

            }
            if(CheckForDigitsAndLetters(pass) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;

            }
            if(CountDigits(pass) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }
            if(invalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool CheckForDigitsAndLetters(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                char currentChar = pass[i];
                if(!((currentChar >= 48 && currentChar <= 57)
                    || (currentChar >= 65 && currentChar <= 90)
                    || (currentChar >= 97 && currentChar <=  122)))
                {
                    return false;
                }

            }
            return true;
        }

        static int CountDigits(string pass)
        {
            int countDigits = 0;

            for (int i = 0; i < pass.Length; i++)
            {
                if(pass[i] >= 48 && pass[i] <= 57 )
                {
                   
                    countDigits++;
                }

            }
            return countDigits;
        }
    }
}

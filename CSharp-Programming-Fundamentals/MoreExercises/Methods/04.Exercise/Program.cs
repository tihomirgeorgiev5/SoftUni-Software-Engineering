using System;

namespace _03.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CheckIfPasswordIsValid(input);



        }
        static void CheckIfPasswordIsValid(string input)
        {
            bool invalid = false;

            if (InRangeCharacters(input) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }
            if (ConsistsOnlyLettersAndDigits(input) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }
            if (ContainsTwoDigits(input) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }
            if (invalid == false)
            {
                Console.WriteLine("Password is valid");

            }
        }
        static bool InRangeCharacters(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        static bool ConsistsOnlyLettersAndDigits(string input)
        {
            



            for (int i = 0; i < input.Length; i++)
            {
                char lowerPass = input[i];
                if (!(lowerPass >= 97 && lowerPass <= 122
                    || lowerPass >= 48 && lowerPass <= 57
                    || lowerPass >= 65 && lowerPass <= 90))
                {
                    
                    return false;
                }
                

            }
            return true;

        }

        static bool ContainsTwoDigits(string input)
        {
            string lowerPass = input.ToLower();
            int countDigit = 0;

            for (int i = 0; i < lowerPass.Length; i++)
            {
                if ((int)lowerPass[i] >= 48 && (int)lowerPass[i] <= 57)
                {
                    countDigit++;
                }
            }
            if (countDigit >= 2)
            {
                
                return true;
            }
            else
            {
                return false;
            }



        }
    }     
    
}

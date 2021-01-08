using System;

namespace _03.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            InRangeCharacters(input);
            ConsistsOnlyLettersAndDigits(input);
            ContainsTwoDigits(input);





            static void InRangeCharacters(string input)
            {
                if (input.Length > 6 && input.Length <= 10)
                {
                    Console.WriteLine("Password is valid");
                }
                else
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
            }
            static void ConsistsOnlyLettersAndDigits(string input)
            {
                string lowerPass = input.ToLower();
                bool isNotValid = false;


                for (int i = 0; i < lowerPass.Length; i++)
                {
                    if ((int)lowerPass[i] >= 97 && (int)lowerPass[i] <= 122
                        && (int)lowerPass[i] >= 48 && (int)lowerPass[i] <= 57)
                    {
                        Console.WriteLine("Password is valid");
                    }
                    else
                    {
                        isNotValid = true;
                    }

                }
                if (isNotValid)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
            }
            static void ContainsTwoDigits (string input)
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
                    Console.WriteLine("Password is Valid");
                }
                else
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

                

            }
        }
    }     
    
}

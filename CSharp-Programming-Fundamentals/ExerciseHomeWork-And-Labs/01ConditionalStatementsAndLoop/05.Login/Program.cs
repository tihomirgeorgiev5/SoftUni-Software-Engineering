using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";


            //  The password will be that username reversed.
            //  Until you receive the correct password print on the console “Incorrect password. Try again.”.
            //  When you receive the correct password print “User { username} logged in.”
            //  However on the fourth try if the password is still not correct print “User { username} blocked!” and end the program.

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            int countIncorrectPass = 0;
            while (true)
            {
                string currentPassword = Console.ReadLine();
               

                if (currentPassword != password)
                {
                    
                    countIncorrectPass++;

                    if (countIncorrectPass == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");


                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                
            }



        }
    }
}

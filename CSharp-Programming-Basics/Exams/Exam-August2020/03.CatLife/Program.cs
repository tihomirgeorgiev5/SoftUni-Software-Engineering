using System;

namespace _03._Cat_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string breed = Console.ReadLine();
            char gender = Convert.ToChar(Console.ReadLine());

            int lifeCat = 0;

            switch (breed)
            {
                case "British Shorthair":
                    if (gender == 'm')
                    {
                        lifeCat = 13;
                    }
                    else if (gender == 'f')
                    {
                        lifeCat = 14;
                    }
                    break;

                case "Siamese":
                    if (gender == 'm')
                    {
                        lifeCat = 15;
                    }
                    else if (gender == 'f')
                    {
                        lifeCat = 16;
                    }
                    break;
                case "Persian":
                    if (gender == 'm')
                    {
                        lifeCat = 14;
                    }
                    else if (gender == 'f')
                    {
                        lifeCat = 15;
                    }
                    break;
                case "Ragdoll":
                    if (gender == 'm')
                    {
                        lifeCat = 16;
                    }
                    else if (gender == 'f')
                    {
                        lifeCat = 17;
                    }
                    break;
                case "American Shorthair":
                    if (gender == 'm')
                    {
                        lifeCat = 12;
                    }
                    else if (gender == 'f')
                    {
                        lifeCat = 13;
                    }
                    break;
                case "Siberian":
                    if (gender == 'm')
                    {
                        lifeCat = 11;
                    }
                    else if (gender == 'f')
                    {
                        lifeCat = 12;
                    }
                    break;
               


            }
            if (breed == "Tom")
            {
                Console.WriteLine($"{"Tom"} is invalid cat!");
            }
            else
            {

                double lifeCatInCatMonths = (lifeCat * 12) / 6;
                Console.WriteLine($"{Math.Floor(lifeCatInCatMonths)} cat months");
            }
        }
    }
}

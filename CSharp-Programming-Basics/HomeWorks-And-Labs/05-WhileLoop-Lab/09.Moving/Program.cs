using System;
using System.Data;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine()); 
            int length = int.Parse(Console.ReadLine()); 
            int height = int.Parse(Console.ReadLine());

            int roomVolume = width * length * height;

            string command = Console.ReadLine();

            while (command != "Done")
            {
                int numberOfBoxes = int.Parse(command);
                roomVolume -= numberOfBoxes;
                if (roomVolume <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs (roomVolume)} Cubic meters more.");
                    break;
                }

                command = Console.ReadLine();
            }
            if (command == "Done") 
            { 
            Console.WriteLine($"{roomVolume} Cubic meters left.");

            }
        }
    }
}

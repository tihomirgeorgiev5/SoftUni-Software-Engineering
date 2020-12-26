using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 стъпки всеки ден.
            //Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си
            //Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път като излиза през деня 
            //и когато постигне целта си да се изписва "Goal reached! Good job!"  
            //и колко стъпки повече е извървяла "{разликата между стъпките} steps over the goal!"
            //Ако иска да се прибере преди това, 
            //тя ще въведе командата "Going home" 
            //и ще въведе стъпките, които е извървяла докато се прибира.
            //След което, ако не е успяла да постигне целта си,
            //на конзолата трябва да се изпише: "{разликата между стъпките} more steps to reach goal."

            string command = Console.ReadLine();
            int totalSteps = 0;
            bool didReachTheGoal = false;

            while (command != "Going home")
            {
                int steps = int.Parse(command);
                totalSteps += steps;

                if (totalSteps >= 10000)
                {
                    didReachTheGoal = true;
                    break;
                }
                command = Console.ReadLine();
            }

            if (didReachTheGoal)
            {
                int stepsOverTheGoal = totalSteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOverTheGoal} steps over the goal!");
            }
            else
            {
                int additionalSteps = int.Parse(Console.ReadLine());
                totalSteps += additionalSteps;

                if (totalSteps >= 10000)
                {
                    int stepsOverTheGoal = totalSteps - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsOverTheGoal} steps over the goal!");
                }
                else
                {
                    int stepsToReachTheGoal = 10000 - totalSteps;
                    Console.WriteLine($"{stepsToReachTheGoal} more steps to reach goal.");
                }
            }
        }    


    }
}

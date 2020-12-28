using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            int divide = 0;
            int remainderOperator = 0;
            int result = 0;
            // Input Output  Comments
            // 17
            // 3   6   5 courses * 3 people
            // + 1 course * 2 persons
            // 4
            // 5   1   All the persons fit inside in the elevator.
            // Only one course is needed.
            // 10
            // 5   2   2 courses * 5 people





            if (numOfPeople >= capacityOfElevator)
            {
                divide = numOfPeople / capacityOfElevator;

                remainderOperator = numOfPeople % capacityOfElevator;
                result = divide + 1;

            }
            else
            {

                Console.WriteLine(1);
                return; 
            }
            if (remainderOperator != 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(divide);
            }


        }
    }
}

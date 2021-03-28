using System;

namespace eNumDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday;

            Console.WriteLine(today);
            Console.WriteLine((int)today);
            Console.WriteLine((Days)15);
        }
    }
    [Flags]
    enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8

    }
}

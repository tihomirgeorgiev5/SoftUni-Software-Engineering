using System;

namespace Rabbits
{
   public class StartUp
    {
        public static void Main(string[] args)
        {
            Cage cage = new Cage("Wildness", 20);

            Rabbit rabbit = new Rabbit("Fluffy", "Blanc de Hotot");

            Console.WriteLine(rabbit);
        }
    }
}

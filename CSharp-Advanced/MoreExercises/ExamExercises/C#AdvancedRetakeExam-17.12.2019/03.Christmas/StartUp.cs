using System;

namespace Christmas
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Present one = new Present("Doll", 100, "girl");
            Present two = new Present("Truck", 200, "boy");

            Bag blueBag = new Bag("blue", 5);

            blueBag.Add(one);
            blueBag.Add(two);

            Console.WriteLine(blueBag.GetPresent("Truck").ToString());
        }
    }
}

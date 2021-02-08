using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 2025;
            car.FuelQuantity = 200;
            car.FuelConsumption = 10;

            car.Drive(2000);

            Console.WriteLine(car.WhoAmI());                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        }
    }
}

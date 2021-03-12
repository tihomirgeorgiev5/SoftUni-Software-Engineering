using System;

namespace Telephony

{
    public class StartUp
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in numbers)
            {
                try
                {
                    if (number.Length == 10)
                    {
                        string result = smartphone.Call(number);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        string result = stationaryPhone.Call(number);
                        Console.WriteLine(result);
                    }
                    
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                     
                }
                
               
            }

            foreach (var url in urls)
            {
                try
                {
                    string result = smartphone.Browse(url);

                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }
           
        }
    }
}

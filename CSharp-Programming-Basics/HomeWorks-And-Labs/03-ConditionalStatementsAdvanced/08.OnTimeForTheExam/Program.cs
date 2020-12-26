using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivedHour = int.Parse(Console.ReadLine());
            int arrivedMinute = int.Parse(Console.ReadLine());

            int examMinutes = examHour * 60 + examMinute;
            int arriveMinutes = arrivedHour * 60 + arrivedMinute;



            if (arriveMinutes > examMinutes)
            {
                //⦁	“Late”, 
                Console.WriteLine("Late");
            }
            else if (arriveMinutes == examMinutes || examMinutes - arriveMinutes <= 30)
            {
                //On time
                Console.WriteLine("On time");
            }
            else if (examMinutes - arriveMinutes > 30)
            {
                //Early
                Console.WriteLine("Early");
            }

            if (examMinutes > arriveMinutes)
            {
                double arriveDiff = examMinutes - arriveMinutes;
                if (arriveDiff < 60 && arriveDiff > 1)
                {
                    Console.WriteLine($"{arriveDiff} minutes before the start");
                }
                else if (arriveDiff >= 60)
                {
                    double diffHour = Math.Floor(arriveDiff / 60);
                    double diffMinute = arriveDiff % 60;
                    if (arriveDiff > 60)
                    {

                        if (diffMinute < 10 && diffMinute > 0)
                        {
                            Console.WriteLine($"{diffHour}:0{diffMinute} hours before the start");
                        }
                        else if (diffMinute == 0)
                        {
                            Console.WriteLine($"{1}:{00} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{diffHour}:{diffMinute} hours before the start");
                        }
                    }
                    else 
                    {
                        Console.WriteLine($"{"1"}:{"00"} hours before the start");
                    }
                    
                }
            }
            else if (examMinutes < arriveMinutes)
            {
                double arriveDiff = arriveMinutes - examMinutes;
                double diffHour = Math.Floor(arriveDiff / 60);
                double diffMinute = arriveDiff % 60;
                if (arriveDiff < 60)
                {
                    if (arriveDiff < 10)
                    {
                        Console.WriteLine($"0{arriveDiff} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{arriveDiff} minutes after the start");
                    }
                }
                else if (arriveDiff >= 60)
                {
                    
                    if (arriveDiff > 60)
                    {

                        if (diffMinute < 10)
                            Console.WriteLine($"{diffHour}:0{diffMinute} hours after the start");
                        else
                        {
                            Console.WriteLine($"{diffHour}:{diffMinute} hours after the start");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{"1"}:{"00"} hours after the start");
                    }
                }

            } 

            
            


        }
    }
}

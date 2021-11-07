using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data;
using System;

namespace P03_FootballBetting
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            /*FootballBettingContext dbContext =new *FootballBettingContext();
            dbContext.Database.EnsureCreated();
            Console.WriteLine("Db created*successfully!");
            Console.WriteLine("Do youwant*todelete //database(Y/N)?");
            string result = Console.ReadLine();
            if (result == "Y")
            {
                dbContext.Database.EnsureDeleted();
                Console.WriteLine("Db deleted*successfully!");
            }*/

            FootballBettingContext db = new FootballBettingContext();

            db.Database.Migrate();
            Console.WriteLine("Db created successfully!");

           
        }
    }
}

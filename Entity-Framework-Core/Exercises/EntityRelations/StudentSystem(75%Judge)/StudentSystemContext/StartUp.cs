
namespace P01_StudentSystem
{
    using System;
    using Data;
    using Microsoft.EntityFrameworkCore;

    public class StartUp
    {
        static void Main(string[] args)
        {
            StudentSystemContext db = new StudentSystemContext();

            db.Database.Migrate();

            Console.WriteLine("Db created successfully!");
        }
    }
}

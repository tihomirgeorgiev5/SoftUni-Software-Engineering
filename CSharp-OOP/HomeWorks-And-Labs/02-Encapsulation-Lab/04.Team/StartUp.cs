using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            Person personBubi = new Person("Bubi", "Bubov", 15, 460);
            try
            {
                var lines = int.Parse(Console.ReadLine());
                var persons = new List<Person>();
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
               

                Team team = new Team("dreamTeam");

                persons.ForEach(p => team.AddPlayer(p));

                Console.WriteLine($"First Team: {team.FirstTeam.Count}");
                Console.WriteLine($"Reserve Team: {team.ReserveTeam.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
        }
    }
}

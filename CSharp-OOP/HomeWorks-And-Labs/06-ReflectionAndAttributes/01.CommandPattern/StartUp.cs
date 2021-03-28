using CommandPattern.Core.Contracts;
using System;
using CommandPattern.Core;

namespace CommandPattern
{
    public class StartUp
    {
        public static void Main()
        {
            ICommandInterpreter command =new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();
        }
    }
}

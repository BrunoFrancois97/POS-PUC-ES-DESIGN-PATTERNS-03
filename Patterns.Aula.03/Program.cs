using System;

namespace Patterns.Aula._03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var actionLogger = new ActionLogger();

            Execute(actionLogger, new ActionCommand("Search", "RTX 2080TI", "192.168.0.1"));
            Execute(actionLogger, new ActionCommand("Upload", "music.mp3", new byte[1]));
            Execute(actionLogger, new ActionCommand("Execute", "this is a test script to be run"));
            Execute(actionLogger, new ActionCommand("Neighbors", 2, "192.168.0.2"));

            Console.ReadKey();
        }

        private static void Execute(ActionLogger actionLogger, ICommand actionCommand)
        {
            actionLogger.SetCommand(actionCommand);
            actionLogger.Invoke();
        }
    }
}

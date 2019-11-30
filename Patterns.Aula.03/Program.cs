namespace Patterns.Aula._03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var actionLogger = new ActionLogger();

            Execute(actionLogger, new ActionCommand("search", "RTX 2080TI", "192.168.0.1"));
        }

        private static void Execute(ActionLogger actionLogger, ICommand actionCommand)
        {
            actionLogger.SetCommand(actionCommand);
            actionLogger.Invoke();
        }
    }
}

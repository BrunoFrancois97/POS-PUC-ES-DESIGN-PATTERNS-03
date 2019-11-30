using System;

namespace Patterns.Aula._03
{
    public class ExecuteLogger : ILogger<ExecuteParams>
    {
        public void Log(ExecuteParams parameters)
        {
            Console.WriteLine($"Execute command received with script {parameters.Script}");
        }
    }
}

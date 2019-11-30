using System.Collections.Generic;

namespace Patterns.Aula._03
{
    public class CommandInvoker
    {
        private readonly IList<ICommand> commands;
        private ICommand command;

        public CommandInvoker()
        {
            commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command) => this.command = command;
        
        public void Invoke()
        {
            commands.Add(command);
            command.ExecuteAction();
        }
    }
}

using System.Collections.Generic;

namespace Patterns.Aula._03
{
    public class ActionLogger
    {
        private readonly IList<ICommand> commands;
        private ICommand command;

        public ActionLogger()
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

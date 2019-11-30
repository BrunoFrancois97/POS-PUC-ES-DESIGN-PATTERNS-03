using System;

namespace Patterns.Aula._03
{
    public class ActionCommand : ICommand
    {
        private readonly string command;
        private readonly string keywords;
        private readonly string destination;
        private readonly string fileName;
        private readonly byte[] content;
        private readonly string script;
        private readonly int depth;

        public ActionCommand(string command, string keywords, string destination)
        {
            this.command = command;
            this.keywords = keywords;
            this.destination = destination;
        }

        public ActionCommand(string command, string fileName, byte[] content)
        {
            this.command = command;
            this.fileName = fileName;
            this.content = content;
        }

        public ActionCommand(string command, string script)
        {
            this.command = command;
            this.script = script;
        }

        public ActionCommand(string command, int depth, string destination)
        {
            this.command = command;
            this.depth = depth;
            this.destination = destination;
        }

        public void ExecuteAction()
        {
            Enum.TryParse<ActionType>(command, out var actionType);

            switch (actionType)
            {
                case ActionType.Execute:
                    return;

                case ActionType.Neighbors:
                    return;

                case ActionType.Serach:
                    return;

                case ActionType.Upload:
                    return;
            }
        }
    }
}

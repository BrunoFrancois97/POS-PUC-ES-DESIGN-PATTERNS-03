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
        private readonly ILogger<SearchParams> searchLogger;
        private readonly ILogger<UploadParams> uploadLogger;
        private readonly ILogger<ExecuteParams> executeLogger;
        private readonly ILogger<NeighborsParams> neighborsLogger;

        //search
        public ActionCommand(string command, string keywords, string destination)
        {
            this.command = command;
            this.keywords = keywords;
            this.destination = destination;
            searchLogger = new SearchLogger();
        }

        //upload
        public ActionCommand(string command, string fileName, byte[] content)
        {
            this.command = command;
            this.fileName = fileName;
            this.content = content;
            uploadLogger = new UploadLogger();
        }

        //execute
        public ActionCommand(string command, string script)
        {
            this.command = command;
            this.script = script;
            executeLogger = new ExecuteLogger();
        }

        //neighbors
        public ActionCommand(string command, int depth, string destination)
        {
            this.command = command;
            this.depth = depth;
            this.destination = destination;
            neighborsLogger = new NeighborsLogger();
        }

        public void ExecuteAction()
        {
            Enum.TryParse<ActionType>(command, out var actionType);

            switch (actionType)
            {
                case ActionType.Execute:
                    LogExecute();
                    return;

                case ActionType.Neighbors:
                    LogNeghbors();
                    return;

                case ActionType.Search:
                    LogSearch();
                    return;

                case ActionType.Upload:
                    LogUpload();
                    return;
            }
        }

        private void LogExecute()
        {
            var searchParams = new ExecuteParams
            {
                Script = script,
            };
            executeLogger.Log(searchParams);
        }

        private void LogNeghbors()
        {
            var searchParams = new NeighborsParams
            {
               Depth = depth,
               Destination = destination,
            };
            neighborsLogger.Log(searchParams);
        }

        private void LogSearch()
        {
            var searchParams = new SearchParams
            {
                Keywords = keywords,
                Destination = destination,
            };
            searchLogger.Log(searchParams);
        }

        private void LogUpload()
        {
            var searchParams = new UploadParams
            {
                Content = content,
                FileName = fileName,
            };
            uploadLogger.Log(searchParams);
        }
    }
}

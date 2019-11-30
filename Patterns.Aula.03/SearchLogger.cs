using System;

namespace Patterns.Aula._03
{
    public class SearchLogger : ILogger<SearchParams>
    {
        public void Log(SearchParams parameters)
        {
            Console.WriteLine($"Search command received to {parameters.Destination} with the following keywords {parameters.Keywords}");
        }
    }
}

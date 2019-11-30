using System;

namespace Patterns.Aula._03
{
    public class NeighborsLogger : ILogger<NeighborsParams>
    {
        public void Log(NeighborsParams parameters)
        {
            Console.WriteLine($"Neighbors command received to destination {parameters.Destination} and depth {parameters.Depth}");
        }
    }
}

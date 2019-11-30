using System;

namespace Patterns.Aula._03
{
    public class UploadLogger : ILogger<UploadParams>
    {
        public void Log(UploadParams parameters)
        {
            Console.WriteLine($"Upload command received with file name {parameters.FileName}");
            Console.ReadKey();
        }
    }
}

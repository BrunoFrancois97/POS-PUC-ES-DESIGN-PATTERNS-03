namespace Patterns.Aula._03
{
    public interface ILogger<T> where T : class
    {
        void Log(T parameters);
    }
}

using System;

namespace DIPTirgul
{
    // Part 2: ConsoleLogger implements ILogger
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}
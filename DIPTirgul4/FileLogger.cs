using System;

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[FILE] {message}");
    }
}
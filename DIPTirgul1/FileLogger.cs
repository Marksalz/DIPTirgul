using System;
using System.IO;

namespace DIPTirgul
{
    // Part 1: FileLogger without interface
    public class FileLogger
    {
        private readonly string _filePath = "log.txt";

        public void Log(string message)
        {
            File.AppendAllText(_filePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }

    // Part 2: FileLogger implements ILogger
    public class FileLoggerWithInterface : ILogger
    {
        private readonly string _filePath = "log.txt";

        public void Log(string message)
        {
            File.AppendAllText(_filePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }
}
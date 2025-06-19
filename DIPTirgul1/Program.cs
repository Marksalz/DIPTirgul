namespace DIPTirgul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Violates DIP
            var missionController = new MissionController();
            missionController.RunMission();

            // Part 2: Respects DIP
            ILogger fileLogger = new FileLoggerWithInterface();
            ILogger consoleLogger = new ConsoleLogger();

            var missionControllerWithFile = new MissionControllerWithDI(fileLogger);
            missionControllerWithFile.RunMission();

            var missionControllerWithConsole = new MissionControllerWithDI(consoleLogger);
            missionControllerWithConsole.RunMission();
        }
    }
}
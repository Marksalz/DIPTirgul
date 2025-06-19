namespace DIPTirgul
{
    // Part 1: Violates DIP
    public class MissionController
    {
        public void RunMission()
        {
            // Mission logic...
            var logger = new FileLogger();
            logger.Log("Mission completed.");
        }
    }

    // Part 2: Respects DIP
    public class MissionControllerWithDI
    {
        private readonly ILogger _logger;

        public MissionControllerWithDI(ILogger logger)
        {
            _logger = logger;
        }

        public void RunMission()
        {
            // Mission logic...
            _logger.Log("Mission completed.");
        }
    }
}
public class ControlRoom
{
    public void Launch()
    {
        ILogger logger = new FileLogger();
        IIntelligenceService intelService = new IntelligenceService();
        IMapService mapService = new MapService();

        MissionPlanner planner = new MissionPlanner(logger, intelService, mapService);
        planner.PlanMission("Sector 9");
    }
}
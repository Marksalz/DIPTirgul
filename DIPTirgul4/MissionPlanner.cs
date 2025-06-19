using System;

public class MissionPlanner
{
    private readonly ILogger _logger;
    private readonly IIntelligenceService _intelService;
    private readonly IMapService _mapService;

    public MissionPlanner(ILogger logger, IIntelligenceService intelService, IMapService mapService)
    {
        _logger = logger;
        _intelService = intelService;
        _mapService = mapService;
    }

    public void PlanMission(string location)
    {
        Console.WriteLine("MISSION BRIEFING:");
        var intel = _intelService.GatherIntel(location);
        var map = _mapService.LoadMap(location);
        Console.WriteLine(intel);
        Console.WriteLine(map);
        _logger.Log($"Mission planned for {location}");
    }
}
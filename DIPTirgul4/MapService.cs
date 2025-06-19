public class MapService : IMapService
{
    public string LoadMap(string location)
    {
        return $"Loaded terrain map for {location}";
    }
}
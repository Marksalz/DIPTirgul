public class IntelligenceService : IIntelligenceService
{
    public string GatherIntel(string location)
    {
        return $"Enemy activity in {location}: HIGH";
    }
}
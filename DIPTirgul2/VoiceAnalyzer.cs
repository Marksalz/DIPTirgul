namespace DIPTirgul2
{
    // Part 1: VoiceAnalyzer without interface
    public class VoiceAnalyzer
    {
        public bool IsLying(string suspectStatement)
        {
            // Dummy logic: returns true if statement contains "lie"
            return suspectStatement.Contains("lie", StringComparison.OrdinalIgnoreCase);
        }
    }
}
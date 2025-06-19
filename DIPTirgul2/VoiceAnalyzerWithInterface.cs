namespace DIPTirgul2
{
    // Part 2: VoiceAnalyzer implements ILieDetector
    public class VoiceAnalyzerWithInterface : ILieDetector
    {
        public bool IsLying(string suspectStatement)
        {
            // Dummy logic: returns true if statement contains "lie"
            return suspectStatement.Contains("lie", StringComparison.OrdinalIgnoreCase);
        }
    }
}
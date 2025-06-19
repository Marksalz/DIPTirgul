namespace DIPTirgul2
{
    // Part 1: Violates DIP
    public class TerroristInterrogationUnit
    {
        public bool Interrogate(string suspectStatement)
        {
            var analyzer = new VoiceAnalyzer();
            return analyzer.IsLying(suspectStatement);
        }
    }
}
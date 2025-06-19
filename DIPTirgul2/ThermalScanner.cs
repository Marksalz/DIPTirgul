namespace DIPTirgul2
{
    // Part 2: ThermalScanner implements ILieDetector
    public class ThermalScanner : ILieDetector
    {
        public bool IsLying(string suspectStatement)
        {
            // Dummy logic: returns true if statement contains "sweat"
            return suspectStatement.Contains("sweat", StringComparison.OrdinalIgnoreCase);
        }
    }
}
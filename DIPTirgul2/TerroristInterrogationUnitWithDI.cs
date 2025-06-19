namespace DIPTirgul2
{
    // Part 2: Respects DIP
    public class TerroristInterrogationUnitWithDI
    {
        private readonly ILieDetector _lieDetector;

        public TerroristInterrogationUnitWithDI(ILieDetector lieDetector)
        {
            _lieDetector = lieDetector;
        }

        public bool Interrogate(string suspectStatement)
        {
            return _lieDetector.IsLying(suspectStatement);
        }
    }
}
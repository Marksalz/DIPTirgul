namespace DIPTirgul3
{
    // Part 1: Violates DIP
    public class BaseDefenseController
    {
        public void HandleThreat()
        {
            var siren = new SirenAlert();
            siren.Alert();
        }
    }
}
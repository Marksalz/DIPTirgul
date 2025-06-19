namespace DIPTirgul3
{
    // Part 2: Respects DIP
    public class BaseDefenseControllerWithDI
    {
        private readonly IAlert _alert;

        public BaseDefenseControllerWithDI(IAlert alert)
        {
            _alert = alert;
        }

        public void HandleThreat()
        {
            _alert.Alert();
        }
    }
}
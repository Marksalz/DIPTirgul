namespace DIPTirgul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Violates DIP
            var controller = new BaseDefenseController();
            controller.HandleThreat();

            // Part 2: Respects DIP
            IAlert siren = new SirenAlertWithInterface();
            IAlert drone = new DroneDispatchAlert();

            var controllerWithSiren = new BaseDefenseControllerWithDI(siren);
            controllerWithSiren.HandleThreat();

            var controllerWithDrone = new BaseDefenseControllerWithDI(drone);
            controllerWithDrone.HandleThreat();
        }
    }
}

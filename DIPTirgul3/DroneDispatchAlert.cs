using System;

namespace DIPTirgul3
{
    // Part 2: DroneDispatchAlert implements IAlert
    public class DroneDispatchAlert : IAlert
    {
        public void Alert()
        {
            Console.WriteLine("Drones dispatched! Danger detected!");
        }
    }
}
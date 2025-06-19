using System;

namespace DIPTirgul3
{
    // Part 2: SirenAlert implements IAlert
    public class SirenAlertWithInterface : IAlert
    {
        public void Alert()
        {
            Console.WriteLine("Siren sounding! Danger detected!");
        }
    }
}
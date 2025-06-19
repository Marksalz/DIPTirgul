using System;

namespace DIPTirgul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Violates DIP
            var unit = new TerroristInterrogationUnit();
            Console.WriteLine("VoiceAnalyzer (violates DIP):");
            Console.WriteLine($"'I never lie' => Lying? {unit.Interrogate("I never lie")}");
            Console.WriteLine($"'I am innocent' => Lying? {unit.Interrogate("I am innocent")}");
            Console.WriteLine();

            // Part 2: Respects DIP
            ILieDetector voiceAnalyzer = new VoiceAnalyzerWithInterface();
            ILieDetector thermalScanner = new ThermalScanner();

            var unitWithVoice = new TerroristInterrogationUnitWithDI(voiceAnalyzer);
            var unitWithThermal = new TerroristInterrogationUnitWithDI(thermalScanner);

            Console.WriteLine("VoiceAnalyzerWithInterface (respects DIP):");
            Console.WriteLine($"'I never lie' => Lying? {unitWithVoice.Interrogate("I never lie")}");
            Console.WriteLine($"'I am innocent' => Lying? {unitWithVoice.Interrogate("I am innocent")}");
            Console.WriteLine();

            Console.WriteLine("ThermalScanner (respects DIP):");
            Console.WriteLine($"'I am starting to sweat' => Lying? {unitWithThermal.Interrogate("I am starting to sweat")}");
            Console.WriteLine($"'I am calm' => Lying? {unitWithThermal.Interrogate("I am calm")}");
        }
    }
}
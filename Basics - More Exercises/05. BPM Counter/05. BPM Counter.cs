namespace BPMCounter
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            double beatsCount = double.Parse(Console.ReadLine());

            double time = (beatsCount / beatsPerMinute) * 60;
            int mins = (int)time / 60;
            double secs = (int)time % 60;

            Console.WriteLine($"{Math.Round(beatsCount / 4, 1)} bars - {mins}m {secs}s");
        }
    }
}
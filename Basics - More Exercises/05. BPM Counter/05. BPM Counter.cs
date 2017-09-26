using System;

public class Program
{
    public static void Main()
    {
        double bpm = double.Parse(Console.ReadLine());
        int numberOfBeats = int.Parse(Console.ReadLine());
        double seconds = ((int)(numberOfBeats) * 60) / (int)(bpm);
        int minutes = 0;
        Console.Write("{0} bars - ", Math.Round(numberOfBeats / 4.0, 1));
        if (seconds > 59)
        {
            minutes = 1;
            seconds -= 60;
            Console.WriteLine("{0}m {1}s", minutes, seconds);
        }
        else
        {
            Console.WriteLine("{0}m {1}s", minutes, seconds);
        }
    }
}
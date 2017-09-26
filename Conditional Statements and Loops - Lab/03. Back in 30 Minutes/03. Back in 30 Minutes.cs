using System;

public class Program
{
    public static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        if (minutes + 30 > 59)
        {
            hours++;
            minutes -= 60;
            if (hours > 23)
            {
                hours = 0;
            }
        }
        Console.WriteLine("{0}:{1:d2}", hours, minutes + 30);
    }
}
using System;

public class Program
{
    public static void Main()
    {
        int photoNumber = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        long size = long.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("Name: DSC_{0:d4}.jpg", photoNumber);
        Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2:d2} {3:d2}:{4:d2}", day, month, year, hours, minutes);

        if (size < 1000)
        {
            Console.WriteLine("Size: {0}B", size);
        }
        else if (size > 1000 && size < 1000000)
        {
            Console.WriteLine("Size: {0}KB", size / 1000);
        }
        else
        {
            Console.WriteLine("Size: {0}MB", Math.Round((size / 1000000.0), 1));
        }
        Console.Write("Resolution: {0}x{1} ", width, height);
        if (width > height)
        {
            Console.WriteLine("(landscape)");
        }
        else if (width == height)
        {
            Console.WriteLine("(square)");
        }
        else
        {
            Console.WriteLine("(portrait)");
        }
    }
}
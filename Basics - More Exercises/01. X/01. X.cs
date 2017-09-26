using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n - 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', a - i * 2));
        }
        Console.WriteLine("{0}x{0}", new string(' ', n / 2));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}x{1}x{0}", new string(' ', (n - 2) / 2 - i), new string(' ', 1 + i * 2));
        }
    }
}
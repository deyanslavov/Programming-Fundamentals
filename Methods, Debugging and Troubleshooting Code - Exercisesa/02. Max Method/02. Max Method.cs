using System;

public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        GetMax(a, b, c);

    }
    static void GetMax(int a, int b, int c)
    {
        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > c && b > a)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}
using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} X {1} = {2}", n, i, n * i);

        }
    }
}
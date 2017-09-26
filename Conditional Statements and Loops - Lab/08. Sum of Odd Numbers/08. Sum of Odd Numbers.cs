using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n * 2; i++)
        {
            if (i % 2 == 1)
            {
                sum += i;
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}
using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        int count = 0;
        int sum = 0;

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                count++;
                sum += 3 * (i * j);
                if (sum >= max)
                {
                    break;
                }
            }
            if (sum >= max)
            {
                break;
            }
        }
        if (sum >= max)
        {
            Console.WriteLine("{0} combinations\nSum: {1} >= {2}", count, sum, max);
        }
        else
        {
            Console.WriteLine("{0} combinations\nSum: {1}", count, sum);
        }
    }
}
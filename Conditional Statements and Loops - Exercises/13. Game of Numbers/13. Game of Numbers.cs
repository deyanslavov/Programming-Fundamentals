using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magic = int.Parse(Console.ReadLine());
        int count = 0;
        int number = 0;
        bool combination = false;
        for (int i = Math.Min(n, m); i <= Math.Max(n, m); i++)
        {
            for (int j = Math.Min(n, m); j <= Math.Max(n, m); j++)
            {
                count++;
                if (j > i && j + i == magic)
                {
                    combination = true;
                    number = j + i;
                    Console.WriteLine("Number found! {0} + {1} = {2}", j, i, number);
                    break;
                }
            }
            if (number == magic)
            {
                break;
            }
        }
        if (combination == false)
        {
            Console.WriteLine("{0} combinations - neither equals {1}", count, magic);
        }
    }
}
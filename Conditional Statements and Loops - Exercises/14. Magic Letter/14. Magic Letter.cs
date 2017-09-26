using System;

public class Program
{
    public static void Main()
    {
        char a = char.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        char x = char.Parse(Console.ReadLine());

        for (char i = a; i <= b; i++)
        {
            for (char j = a; j <= b; j++)
            {
                for (char k = a; k <= b; k++)
                {
                    if (i != x && j != x && k != x)
                    {
                        Console.Write("{0}{1}{2} ", i, j, k);
                    }
                }
            }
        }
    }
}
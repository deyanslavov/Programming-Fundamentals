using System;

public class Program
{
    public static void Main()
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        char thirdChar = char.Parse(Console.ReadLine());

        for (char i = firstChar; i <= secondChar; i++)
        {
            for (char j = firstChar; j <= secondChar; j++)
            {
                for (char k = firstChar; k <= secondChar; k++)
                {
                    if (i != thirdChar && j != thirdChar && k != thirdChar)
                    {
                        Console.Write("{0}{1}{2} ", i, j, k);
                    }
                }
            }
        }
    }
}
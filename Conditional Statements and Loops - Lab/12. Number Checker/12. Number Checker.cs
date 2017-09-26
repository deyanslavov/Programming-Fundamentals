using System;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int num = 0;

        if (int.TryParse(input, out num) == true)
        {
            Console.WriteLine("It is a number.");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
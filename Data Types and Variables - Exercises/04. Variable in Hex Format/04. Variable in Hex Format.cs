using System;

public class Program
{
    public static void Main()
    {
        string myHex = Console.ReadLine();
        int myNewInt = Convert.ToInt32(myHex, 16);

        Console.WriteLine(myNewInt);
    }
}
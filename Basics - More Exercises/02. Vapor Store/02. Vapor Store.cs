using System;

public class Program
{
    public static void Main()
    {
        double balance = double.Parse(Console.ReadLine());
        double balanceLeft = balance;
        double OutFall4 = 39.99;
        double CS = 15.99;
        double ZplinterZell = 19.99;
        double Honored2 = 59.99;
        double RoverWatch = 29.99;
        double RoverWatchOrigins = 39.99;
        double totalSpent = 0.00;

        for (int i = 0; i >= 0; i++)
        {
            string input = Console.ReadLine();
            if (input == "OutFall 4")
            {
                if (balanceLeft >= OutFall4)
                {
                    totalSpent += OutFall4;
                    balanceLeft -= OutFall4;
                    Console.WriteLine("Bought OutFall 4");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "CS: OG")
            {
                if (balanceLeft >= CS)
                {
                    totalSpent += CS;
                    balanceLeft -= CS;
                    Console.WriteLine("Bought CS: OG");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "Zplinter Zell")
            {
                if (balanceLeft >= ZplinterZell)
                {
                    totalSpent += ZplinterZell;
                    balanceLeft -= ZplinterZell;
                    Console.WriteLine("Bought Zplinter Zell");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "Honored 2")
            {
                if (balanceLeft >= Honored2)
                {
                    totalSpent += Honored2;
                    balanceLeft -= Honored2;
                    Console.WriteLine("Bought Honored 2");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "RoverWatch")
            {
                if (balanceLeft >= RoverWatch)
                {
                    totalSpent += RoverWatch;
                    balanceLeft -= RoverWatch;
                    Console.WriteLine("Bought RoverWatch");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "RoverWatch Origins Edition")
            {
                if (balanceLeft >= RoverWatchOrigins)
                {
                    totalSpent += RoverWatchOrigins;
                    balanceLeft -= RoverWatchOrigins;
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

            }
            else if (input == "Game Time")
            {
                Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", totalSpent, balanceLeft);
                break;
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            if (balanceLeft == 0)
            {
                Console.WriteLine("Out of money!");
                break;
            }
        }
    }
}
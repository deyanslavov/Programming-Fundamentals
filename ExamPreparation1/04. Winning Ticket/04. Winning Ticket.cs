using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var ticketsLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var pattern = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}";
        int leftCount = 1;
        int rightCount = 1;
        char currentChar = 'a';
        char lastChar = 'a';
        char leftChar = 'a';
        char rightChar = 'a';

        foreach (var ticket in ticketsLine)
        {
            if (ticket.Length == 20)
            {
                StringBuilder firstHalf = new StringBuilder();
                StringBuilder secondHalf = new StringBuilder();
                for (int i = 0; i < ticket.Length/2; i++)
                {
                    firstHalf.Append(ticket[i]);
                }
                for (int i = 10; i < ticket.Length; i++)
                {
                    secondHalf.Append(ticket[i]);
                }

                var firstMatch = Regex.Match(firstHalf.ToString(), pattern); 
                var secondMatch = Regex.Match(secondHalf.ToString(), pattern);

                if (firstMatch.Success && secondMatch.Success)
                {
                    if (firstMatch.ToString()[0] == secondMatch.ToString()[0])
                    {
                        if (Math.Min(firstMatch.ToString().Length, secondMatch.ToString().Length) >= 6 && Math.Min(firstMatch.ToString().Length, secondMatch.ToString().Length) <= 9)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(firstMatch.ToString().Length, secondMatch.ToString().Length)}{firstMatch.ToString()[0]}");
                        }
                        else if (Math.Min(firstMatch.ToString().Length, secondMatch.ToString().Length) == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(firstMatch.ToString().Length, secondMatch.ToString().Length)}{firstMatch.ToString()[0]} Jackpot!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }             
            }
            else
            {
                Console.WriteLine("invalid ticket");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var items = Console.ReadLine().Split().Select(int.Parse).ToList();
        var command = Console.ReadLine();
        while (command != "end")
        {
            var tokens = command.Split().ToArray();

            if (tokens[0] == "exchange")
            {
                int count = int.Parse(tokens[1]);
                if (count > items.Count - 1)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    items = items.Skip(count + 1).ToList().Concat(items.Take(count + 1)).ToList();
                }
            }
            else if (tokens[0] == "max" && tokens[1] == "even")
            {
                PrintMaxEvenIndex(items);
            }
            else if (tokens[0] == "max" && tokens[1] == "odd")
            {
                PrintMaxOddIndex(items);
            }
            else if (tokens[0] == "min" && tokens[1] == "even")
            {
                PrintMinEvenIndex(items);
            }
            else if (tokens[0] == "min" && tokens[1] == "odd")
            {
                PrintMinOddIndex(items);
            }
            else if (tokens[0] == "first" && tokens[2] == "even")
            {
                int count = int.Parse(tokens[1]);
                PrintFirstEvens(items, count);
            }
            else if (tokens[0] == "first" && tokens[2] == "odd")
            {
                int count = int.Parse(tokens[1]);
                PrintFirstOdds(items, count);
            }
            else if (tokens[0] == "last" && tokens[2] == "even")
            {
                int count = int.Parse(tokens[1]);
                PrintLastEvens(items, count);
            }
            else if (tokens[0] == "last" && tokens[2] == "odd")
            {
                int count = int.Parse(tokens[1]);
                PrintLastOdds(items, count);
            }
            command = Console.ReadLine();
        }
        Console.WriteLine("[" + string.Join(", ", items) + "]");
    }

    private static void PrintLastOdds(List<int> items, int count)
    {
        var odds = new List<int>();
        if (count > items.Count)
        {
            Console.WriteLine("Invalid count");
        }
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] % 2 == 1)
            {
                odds.Add(items[i]);
            }
        }
        if (count > items.Count)
        {
            return;
        }
        else
            odds = odds.Take(count).ToList();
        Console.WriteLine("[" + string.Join(", ", odds) + "]");
    }

    private static void PrintLastEvens(List<int> items, int count)
    {
        var evens = new List<int>();
        if (count > items.Count)
        {
            Console.WriteLine("Invalid count");
        }
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] % 2 == 0)
            {
                evens.Add(items[i]);
            }
        }
        if (count > items.Count)
        {
            return;
        }
        else
            evens = evens.Take(count).ToList();
        Console.WriteLine("[" + string.Join(", ", evens) + "]");
    }

    private static void PrintFirstOdds(List<int> items, int count)
    {
        var odds = new List<int>();
        if (count > items.Count)
        {
            Console.WriteLine("Invalid count");
        }
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] % 2 == 1)
            {
                odds.Add(items[i]);
            }
        }
        if (count > items.Count)
        {
            return;
        }
        else
            odds = odds.Take(count).ToList();
        Console.WriteLine("[" + string.Join(", ", odds) + "]");
    }

    private static void PrintFirstEvens(List<int> items, int count)
    {
        var evens = new List<int>();
        if (count > items.Count)
        {
            Console.WriteLine("Invalid count");
        }
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] % 2 == 0)
            {
                evens.Add(items[i]);
            }
        }
        if (count > items.Count)
        {
            return;
        }
        else
        evens = evens.Take(count).ToList();
        Console.WriteLine("[" + string.Join(", ", evens) + "]");
    }

    private static void PrintMinOddIndex(List<int> items)
    {
        var currentIndex = int.MinValue;
        var currentValue = int.MinValue;
        var bestValue = int.MaxValue;
        var bestIndex = -1;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] % 2 == 1)
            {
                currentValue = items[i];
                currentIndex = i;
                if (currentValue <= bestValue)
                {
                    bestValue = currentValue;
                    bestIndex = currentIndex;
                }
            }
        }
        if (bestIndex < 0)
        {
            Console.WriteLine("No matches");
        }
        else
            Console.WriteLine(bestIndex);
    }

    private static void PrintMinEvenIndex(List<int> items)
    {
        var currentIndex = int.MinValue;
        var currentValue = int.MinValue;
        var bestValue = int.MaxValue;
        var bestIndex = -1;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] % 2 == 0)
            {
                currentValue = items[i];
                currentIndex = i;
                if (currentValue <= bestValue)
                {
                    bestValue = currentValue;
                    bestIndex = currentIndex;
                }
            }
        }
        if (bestIndex < 0)
        {
            Console.WriteLine("No matches");
        }
        else
            Console.WriteLine(bestIndex);
    }

    private static void PrintMaxOddIndex(List<int> items)
    {
        var currentIndex = int.MinValue;
        var currentValue = int.MinValue;
        var bestValue = int.MinValue;
        var bestIndex = int.MinValue;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] % 2 != 0)
            {
                currentValue = items[i];
                currentIndex = i;
                if (currentValue >= bestValue)
                {
                    bestValue = currentValue;
                    bestIndex = currentIndex;
                }
            }
        }
        if (bestIndex < 0)
        {
            Console.WriteLine("No matches");
        }
        else
            Console.WriteLine(bestIndex);
    }

    private static void PrintMaxEvenIndex(List<int> items)
    {
        var currentIndex = int.MinValue;
        var currentValue = int.MinValue;
        var bestValue = int.MinValue;
        var bestIndex = int.MinValue;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] % 2 == 0)
            {
                currentValue = items[i];
                currentIndex = i;
                if (currentValue >= bestValue)
                {
                    bestIndex = currentIndex;
                }
            }
        }
        if (bestIndex < 0)
        {
            Console.WriteLine("No matches");
        }
        else
        Console.WriteLine(bestIndex);
    }
}


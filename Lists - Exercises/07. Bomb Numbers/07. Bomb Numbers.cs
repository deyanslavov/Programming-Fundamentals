namespace _07.Bomb_Numbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombNumberAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == bombNumberAndPower[0])
                {
                    if (input.Count - i - 1 < bombNumberAndPower[1])
                    {
                        input.RemoveRange(i + 1, input.Count - 1 - i);                       
                        input.RemoveAt(i);
                        input.RemoveRange(i - bombNumberAndPower[1], bombNumberAndPower[1]);
                        i = -1;
                    }
                    else if (bombNumberAndPower[1] > input.Count - 2 - (input.Count - 1 - i))
                    {
                        input.RemoveRange(i + 1, bombNumberAndPower[1]);                       
                        input.RemoveAt(i);
                        input.RemoveRange(0, input.Count - 1 - (input.Count - 1 - i));
                        i = -1;
                    }
                    else
                    {
                        input.RemoveRange(i + 1, bombNumberAndPower[1]);      
                        input.RemoveAt(i);
                        input.RemoveRange(i - bombNumberAndPower[1], bombNumberAndPower[1]);
                        i = -1;
                    }
                }
            }
            Console.WriteLine(input.Sum());
        }
    }
}

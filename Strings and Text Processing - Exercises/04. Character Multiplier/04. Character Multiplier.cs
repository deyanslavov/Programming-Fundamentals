namespace _04.Character_Multiplier
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var firstString = input[0];
            var secondString = input[1];
            long result = 0;

            int length = Math.Min(firstString.Length, secondString.Length);

            for (int i = 0; i < length; i++)
            {
                result += Convert.ToInt32(firstString[i]) * Convert.ToInt32(secondString[i]);
            }

            var longer = firstString.Length > secondString.Length ? firstString : secondString;
            for (int i = length; i < longer.Length; i++)
            {
                result += Convert.ToInt32(longer[i]);
            }

            Console.WriteLine(result);
        }
    }
}

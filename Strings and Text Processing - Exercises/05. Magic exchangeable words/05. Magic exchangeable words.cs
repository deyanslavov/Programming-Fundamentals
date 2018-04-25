namespace _05.Magic_exchangeable_words
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

            var arrayOne = firstString.ToCharArray().Distinct().ToArray();
            var arrayTwo = secondString.ToCharArray().Distinct().ToArray();

            if (arrayOne.Length == arrayTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

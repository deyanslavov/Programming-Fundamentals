namespace _09.Melrah_Shake
{
    using System;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var firstIndex = input.IndexOf(pattern);
                var lastIndex = input.LastIndexOf(pattern);
                var isEmpty = pattern == string.Empty;
                var leftAndRightIsEqual = firstIndex == lastIndex;
                if (firstIndex != -1 && lastIndex != -1 && !leftAndRightIsEqual && !isEmpty)
                {
                    input = input.Remove(lastIndex, pattern.Length);
                    input = input.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}

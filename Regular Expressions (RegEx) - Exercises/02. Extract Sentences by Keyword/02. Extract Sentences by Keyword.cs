namespace _02.Extract_Sentences_by_Keyword
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            var word = Console.ReadLine();
            var input = Console.ReadLine().Split('.', '!' , '?').ToArray();
            var pattern = $"{word}[\\s][\\w+]+";

            Regex regex = new Regex(pattern);
            

            foreach (var s in input)
            {
                var matches = regex.Match(s);
                if (matches.Success)
                {
                    Console.WriteLine(s.Trim());
                }
            }
        }
    }
}

namespace _03.Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    class Regexmon
    {
        static void Main(string[] args)
        {
            Regex didimon = new Regex(@"[^a-zA-Z-]+");
            Regex bojomon = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");

            Match match;
            string text = Console.ReadLine();
            string matchedText = "";
            int index = 0;

            while (true)
            {
                match = didimon.Match(text, index);
                if (match.Success)
                {
                    matchedText = match.Value;
                    index = match.Index + matchedText.Length;
                    Console.WriteLine(matchedText);
                }
                else
                {
                    break;
                }

                match = bojomon.Match(text, index);
                if (match.Success)
                {
                    matchedText = match.Value;
                    index = match.Index + matchedText.Length;
                    Console.WriteLine(matchedText);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
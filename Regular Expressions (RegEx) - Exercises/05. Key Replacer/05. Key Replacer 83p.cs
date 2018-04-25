namespace _05.Key_Replacer
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            var key = Console.ReadLine();
            var keyReversed = "";
            for (int i = key.Length-1; i >= 0; i--)
            {
                keyReversed += key[i];
            }
            var text = Console.ReadLine();
            if (key == string.Empty)
            {
                Console.WriteLine("Empty result");
                return;
            }
            var Pattern = @"[\w]+(\||\<|\\)";
            Regex startKey = new Regex(Pattern);
            Regex endKey = new Regex(Pattern);
            var stringResult = "";
            var start = startKey.Match(key).ToString();
            start = start.Remove(start.Length - 1, 1);
            var endReversed = endKey.Match(keyReversed).ToString();
            var end = "";
            for (int i = endReversed.Length - 2; i >= 0; i--)
            {
                end += endReversed[i];
            }
            while (text.Contains(end) && text.Contains(start) && start != end)
            {
                var firstIndex = text.IndexOf(start);
                var lastIndex = text.IndexOf(end);
                var length = lastIndex - (firstIndex + start.Length);
                var textToAdd = text.Substring(firstIndex + start.Length, length);
                text = text.Remove(lastIndex, end.Length);
                text = text.Remove(text.IndexOf(textToAdd), textToAdd.Length);
                text = text.Remove(firstIndex, start.Length);
                stringResult += textToAdd;
            }
            if (stringResult.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(stringResult);
            }
        }
    }
}

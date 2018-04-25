namespace _01.Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            var pattern = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z0-9]+([-.]*\w*)*(\.[a-z]+)";

            var input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            var match = regex.Matches(input);
            foreach (var m in match)
            {
                Console.WriteLine(m);
            }

        }
    }
}

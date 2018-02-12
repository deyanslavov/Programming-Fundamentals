using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var usernames = new List<string>();
            var longestUsernames = new List<string>();
            var pattern = @"\b[a-zA-Z][\w]*[_]?[\w]*\b";
            Regex regex = new Regex(pattern);
            var currentBest = 0;
            var best = int.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
                Match match = regex.Match(input[i]);
                if (match.Success && input[i].Length >= 3 && input[i].Length <= 25)
                {
                    usernames.Add(input[i]);
                }
            }
            for (int i = 0; i < usernames.Count-1; i++)
            {
                currentBest = usernames[i].Length + usernames[i + 1].Length;
                if (currentBest > best)
                {
                    best = currentBest;
                    longestUsernames.Clear();
                    longestUsernames.Add(usernames[i]);
                    longestUsernames.Add(usernames[i+1]);
                }
            }
            Console.WriteLine(string.Join("\r\n", longestUsernames));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
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

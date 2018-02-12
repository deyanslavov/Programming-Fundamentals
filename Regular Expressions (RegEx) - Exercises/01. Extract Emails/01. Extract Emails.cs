using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var encodedText = Console.ReadLine();
            var values = Console.ReadLine().Split(new char[] { '}', '{' }, StringSplitOptions.RemoveEmptyEntries).ToArray() ;

            Regex regex = new Regex(@"([a-zA-Z]+)(.+)(\1)"); 

            var newStr = encodedText;
            var matches = regex.Matches(encodedText);
            if (matches.Count == 0)
            {
                Console.WriteLine(newStr);
                return;
            }

            for (int i = 0; i < matches.Count; i++)
            {
               var m =  matches[i].Groups[2].ToString();

                int index = encodedText.IndexOf(m);
                var toReplace = encodedText.Substring(index, m.Length);

                newStr = newStr.Replace(m, values[i]);
            }
            Console.WriteLine(newStr);
        }
    }
}

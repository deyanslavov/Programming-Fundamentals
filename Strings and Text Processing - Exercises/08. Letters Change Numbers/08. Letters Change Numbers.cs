using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal sum = 0;
            decimal result = 0;

            foreach (var str in input)
            {
                var firstChar = str.First();
                var lastChar = str.Last();
                decimal num = decimal.Parse(str.Substring(1, str.Length - 2));

                if (char.IsUpper(firstChar))
                {
                    sum += num / (firstChar - ('A' - 1));
                }
                else
                {
                    sum += num * (firstChar - ('a' - 1));
                }
                if (char.IsUpper(lastChar))
                {
                    sum -= lastChar - ('A' - 1);
                }
                else
                {
                    sum += lastChar - ('a' - 1);
                }
                result += sum;
                sum = 0;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}

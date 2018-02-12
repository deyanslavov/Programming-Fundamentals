using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var demons = new SortedDictionary<string, List<double>>();

            var charPattern = @"[^\d\-*\/\.]";
            var digitPattern =  @"-?\d+(?:\.\d+)?";
            var symbolsPattern = @"[*]|[/]";

            foreach (var d in input)
            {
                var HealthAndDmg = new List<double> { 0, 0 };
                double hp = 0;
                double dmg = 0;

                var charMatches = Regex.Matches(d, charPattern);
                var digitMatches = Regex.Matches(d, digitPattern);
                var symbolMatches = Regex.Matches(d, symbolsPattern);

                for (int i = 0; i < charMatches.Count; i++)
                {
                    hp += (int)char.Parse(charMatches[i].ToString());
                }
                for (int i = 0; i < digitMatches.Count; i++)
                {
                    dmg += double.Parse(digitMatches[i].ToString());
                }
                for (int i = 0; i < symbolMatches.Count; i++)
                {
                    if (symbolMatches[i].ToString() == "*")
                    {
                        dmg *= 2;
                    }
                    else
                    {
                        dmg /= 2;
                    }
                }
                HealthAndDmg[0] = hp;
                HealthAndDmg[1] = dmg;
                demons.Add(d, HealthAndDmg);
            }
            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage ");
            }

        }
    }
}

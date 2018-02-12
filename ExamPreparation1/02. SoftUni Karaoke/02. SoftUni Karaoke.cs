using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            while (true)
            {
                var performance = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (performance[0] == "dawn")
                {
                    break;
                }
                string participant = performance[0];
                string song = performance[1];
                string award = performance[2];

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!output.ContainsKey(participant))
                    {
                        output[participant] = new List<string>();
                        output[participant].Add(award);
                    }
                    else
                    {
                        if (output[participant].Contains(award))
                        {
                            continue;
                        }
                        else
                        {
                            output[participant].Add(award);
                        }
                    }

                }
            }
            if (output.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var p in output.OrderByDescending(p => p.Value.Distinct().Count()).ThenBy(p => p.Key))
                {
                    Console.WriteLine(p.Key + ": {0} awards", p.Value.Count);
                    foreach (var v in p.Value.OrderBy(k => k))
                    {
                        Console.WriteLine("--{0}", v);
                    }
                }
            }
        }
    }
}

namespace _03.Football_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();

            var League = new Dictionary<string, List<ulong>>();

            while (input.ToLower() != "final")
            {
                var tokens = input.Split().ToArray();

                var decryptedTeamHome = tokens[0];
                int startIndex = decryptedTeamHome.IndexOf(key);
                int endIndex = decryptedTeamHome.LastIndexOf(key);
                string homeTeam = decryptedTeamHome.Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
                char[] homeTeamArray = homeTeam.ToUpper().ToCharArray();
                Array.Reverse(homeTeamArray);
                homeTeam = new string(homeTeamArray);

                var decryptedTeamAway = tokens[1];
                startIndex = decryptedTeamAway.IndexOf(key);
                endIndex = decryptedTeamAway.LastIndexOf(key);
                string awayTeam = decryptedTeamAway.Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
                char[] awayTeamArray = awayTeam.ToUpper().ToCharArray();
                Array.Reverse(awayTeamArray);
                awayTeam = new string(awayTeamArray);

                var score = tokens[2].Split(':').Select(ulong.Parse).ToArray();
                ulong goalsHomeTeam = score[0];
                ulong goalsGuestTeam = score[1];

                ulong pointsHomeTeam = 0;
                ulong pointsGuestTeam = 0;

                if (goalsGuestTeam > goalsHomeTeam)
                {
                    pointsGuestTeam = 3;
                    pointsHomeTeam = 0;
                }
                else if (goalsGuestTeam < goalsHomeTeam)
                {
                    pointsGuestTeam = 0;
                    pointsHomeTeam = 3;
                }
                else
                {
                    pointsHomeTeam = 1;
                    pointsGuestTeam = 1;
                }


                if (!League.ContainsKey(homeTeam))                  // 1 - goals, 2 - points
                {
                    var scores = new List<ulong>();
                    scores.Add(goalsHomeTeam);
                    scores.Add(pointsHomeTeam);
                    League.Add(homeTeam, scores);
                }
                else
                {
                    League[homeTeam][0] += goalsHomeTeam;
                    League[homeTeam][1] += pointsHomeTeam;
                }
                if (!League.ContainsKey(awayTeam))                  // 1 - goals, 2 - points
                {
                    var scores = new List<ulong>();
                    scores.Add(goalsGuestTeam);
                    scores.Add(pointsGuestTeam);
                    League.Add(awayTeam, scores);
                }
                else
                {
                    League[awayTeam][0] += goalsGuestTeam;
                    League[awayTeam][1] += pointsGuestTeam;
                }
                input = Console.ReadLine();
            }
            PrintResult(League);

        }

        private static void PrintResult(Dictionary<string, List<ulong>> League)
        {
            checked
            {
                Console.WriteLine("League standings:");
                int count = 1;
                foreach (var t in League.OrderByDescending(a => a.Value[1]).ThenBy(a => a.Key))
                {
                    Console.WriteLine($"{count}. {t.Key.ToUpper()} {t.Value[1]}");
                    count++;
                }
                Console.WriteLine("Top 3 scored goals:");
                var orderedByGoals = League.OrderByDescending(a => a.Value[0]).ThenBy(a => a.Key).Take(3);
                foreach (var g in orderedByGoals)
                {
                    Console.WriteLine($"- {g.Key.ToUpper()} -> {g.Value[0]}");
                }
            }
        }

        private static string ReverseTeamName(string teamName)
        {
            string name = "";
            for (int i = teamName.Length - 1; i >= 0; i--)
            {
                name += teamName[i];
            }
            return name;
        }
    }
}

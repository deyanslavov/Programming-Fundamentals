using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine().Split(':').ToArray();
            long timeInSeconds = long.Parse(time[0]) * 3600 + long.Parse(time[1]) * 60 + long.Parse(time[2]);
            long steps = long.Parse(Console.ReadLine());
            long seconds = long.Parse(Console.ReadLine());

            long secondsNeeded = steps * seconds;
            var startTime = TimeSpan.FromSeconds(timeInSeconds).ToString().Split(':').ToArray();
            //var neededTime = TimeSpan.FromSeconds(secondsNeeded).ToString().Split(':').ToList();

            long hours = secondsNeeded / 3600;
            long tHours = hours;
            if (hours > 24)
            {
                hours = hours - (hours / 24) * 24;

            }
            long minutes = (secondsNeeded - tHours * 3600) / 60;
            long secondsResult = (secondsNeeded - tHours * 3600) - minutes * 60;
            long[] result = { 0, 0, 0 };

            result[2] = long.Parse(startTime[2]) + secondsResult;
            if (result[2] > 59)
            {
                result[1] += 01;
                result[2] -= 60;
            }
            if (result[1] > 59)
            {
                result[0] += 1;
                result[1] -= 60;
            }
            if (result[0] > 23)
            {
                result[0] = 0;
            }

            result[1] += long.Parse(startTime[1]) + minutes;
            if (result[1] > 59)
            {
                result[0] += 1;
                result[1] -= 60;
            }
            if (result[0] > 23)
            {
                result[0] = 0;
            }

            result[0] += long.Parse(startTime[0]) + hours;
            if (result[0] > 23)
            {
                result[0] -= 24;
            }

            Console.WriteLine("Time Arrival: {0:D2}:{1:d2}:{2:D2}", result[0], result[1], result[2]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal wingFlaps = decimal.Parse(Console.ReadLine());
            decimal distancePer1000Flaps = decimal.Parse(Console.ReadLine());
            decimal endurance = decimal.Parse(Console.ReadLine());

            decimal totalDistance = (wingFlaps / 1000) * distancePer1000Flaps;
            long secondsPassed = (long)((long)(wingFlaps / 100) + (long)(wingFlaps / endurance) * 5);

            Console.WriteLine($"{totalDistance:f2} m.");
            Console.WriteLine($"{secondsPassed:f0} s.");
        }
    }
}

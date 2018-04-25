using System;
using System.Linq;

class Program
{
    static void Main()
    {
        checked
        {

            var drivers = Console.ReadLine().Split().ToArray();
            var trackZones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var checkpointIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                var currentDriver = drivers[i];
                double fuel = (int)currentDriver[0];
                for (int j = 0; j < trackZones.Length; j++)
                {
                    if (checkpointIndexes.Contains(j))
                    {
                        fuel += trackZones[j];
                    }
                    else
                    {
                        fuel -= trackZones[j];
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{currentDriver} - reached {j}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{currentDriver} - fuel left {fuel:f2}");
                }
            }
        }
    }
}

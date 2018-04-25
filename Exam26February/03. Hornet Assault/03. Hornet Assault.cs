namespace _03.Hornet_Assault
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var beehives = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            
            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }
                var sumOfPower = hornets.Sum();

                if (sumOfPower > beehives[i])
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= sumOfPower;
                    hornets.RemoveAt(0);
                }
            }
            var count = beehives.Count;
            for (int i = 0; i < count; i++)
            {
                beehives.Remove(0);
            }
            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}

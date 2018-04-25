namespace Problem_1.Charity_Marathon
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long lengthOfMarathonInDays = long.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            long numberOfLapsPerRunner = long.Parse(Console.ReadLine());
            long TrackLength = long.Parse(Console.ReadLine());
            long TrackCapacity = long.Parse(Console.ReadLine());
            double moneyDonatedPerKM = double.Parse(Console.ReadLine());

            if (TrackCapacity * lengthOfMarathonInDays < numberOfRunners)
            {
                numberOfRunners = TrackCapacity * lengthOfMarathonInDays;
            }

            long totalKM = (numberOfRunners * numberOfLapsPerRunner * TrackLength) / 1000;
            double moneyRaised = totalKM * moneyDonatedPerKM;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}

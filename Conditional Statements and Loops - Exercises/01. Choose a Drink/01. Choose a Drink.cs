namespace _01.Choose_a_Drink
{
    using System;

    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            switch (profession)
            {
                case "Athlete": Console.WriteLine("Water");
                    break;
                case "Businessman":
                case "Businesswoman": Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student": Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}

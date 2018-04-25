namespace _04.Beverage_Labels
{
    using System;

    class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, volume*(energy/100), volume*(sugar/100));
        }
    }
}

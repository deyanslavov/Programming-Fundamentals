namespace _10.Cube_Properties
{
    using System;

    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            FindArea(side, parameter);
        }

        private static void FindArea(double side, string parameter)
        {
            switch(parameter)
            {
                case "face":
                    Console.WriteLine(Math.Round(Math.Sqrt(2*side*side), 2));
                    break;
                case "space":
                    Console.WriteLine(Math.Round(Math.Sqrt(3 * side * side), 2));
                    break;
                case "volume":
                    Console.WriteLine(Math.Round(Math.Pow(side, 3), 2));
                    break;
                case "area":
                    Console.WriteLine(Math.Round(6*side*side, 2));
                    break;
            }
        }
    }
}

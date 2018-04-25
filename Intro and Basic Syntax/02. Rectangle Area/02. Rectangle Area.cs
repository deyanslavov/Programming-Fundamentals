namespace _02.Rectangle_Area
{
    using System;

    class Program
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double area = sideA * sideB;

            Console.WriteLine("{0:f2}", area);
        }
    }
}

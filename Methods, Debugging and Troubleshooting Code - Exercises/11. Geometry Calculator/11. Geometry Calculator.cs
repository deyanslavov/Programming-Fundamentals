namespace _11.Geometry_Calculator
{
    using System;

    class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine().ToLower();
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetTriangleArea(side, height));
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetSquareArea(side));
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetRectangleArea(width, height));
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetCircleArea(radius));
            }
        }
        static double GetTriangleArea(double a, double h)
        {
            double area = (a * h) / 2;
            return area;
        }
        static double GetSquareArea(double a)
        {
            double area = (a * a);
            return area;
        }
        static double GetRectangleArea(double a, double b)
        {
            double area = (a * b);
            return area;
        }
        static double GetCircleArea(double r)
        {
            double area = (2*Math.PI*r*r)/ 2;
            return area;
        }
    }
}

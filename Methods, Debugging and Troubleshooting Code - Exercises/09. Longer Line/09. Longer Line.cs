using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            var longerLine = Math.Max(FindLongerLine(x1, y1, x2, y2), FindLongerLine(x3, y3, x4, y4));

            if (FindLongerLine(x1, y1, x2, y2) > FindLongerLine(x3, y3, x4, y4))
            {
                FindClosestPoint(x2, y2, x1, y1);
            }
            else
            {
                FindClosestPoint(x4, y4, x3, y3);
            }
        }

        static double FindLongerLine(double x1, double y1, double x2, double y2)
        {
            var result = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1, 2));
            return result;
        }

        private static void FindClosestPoint(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (distance > distance2)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
        }
    }
}

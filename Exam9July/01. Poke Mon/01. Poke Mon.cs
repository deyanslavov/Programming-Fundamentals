using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double half = n * 0.5;
            int count = 0;

            while (n >= m)
            {
                if (n == half && n != 0 && y != 0)
                {
                    n = n / y;
                }
                if (n >= m)
                {
                    n -= m;
                    count++;
                }   
            }
            Console.WriteLine($"{n}\n{count}");
        }
    }
}

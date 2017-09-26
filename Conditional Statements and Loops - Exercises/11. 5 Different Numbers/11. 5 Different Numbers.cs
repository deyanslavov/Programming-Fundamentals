using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool condition = false;
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = a; k <= b; k++)
                    {
                        for (int q = a; q <= b; q++)
                        {
                            for (int w = a; w <= b; w++)
                            {
                                if (a <= i && i < j && j < k && k < q && q < w && w <= b)
                                {
                                    Console.Write("{0} {1} {2} {3} {4}", i, j, k, q, w);
                                    Console.WriteLine();
                                    condition = true;
                                }
                            }
                        }
                    }
                }
            }
            if (condition == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}

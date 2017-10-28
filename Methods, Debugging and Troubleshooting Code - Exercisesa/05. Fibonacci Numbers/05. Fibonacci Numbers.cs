﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintAllFibonacci(n));
        }

        private static long PrintAllFibonacci(long n)
        {
            long sum = 0;
            long n1 = 2;
            long n2 = 1;

            if (n == 0 || n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    sum = n1 + n2;
                    n2 = n1;
                    n1 = sum;
                }
                return sum;
            }
        }
    }
}

using System;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
        static bool IsPrime(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number == 4)
            {
                return false;
            }
            var b = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= b; i+=2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

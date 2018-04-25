namespace _13.Factorial
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(FindFactorial(n));
        }

        private static BigInteger FindFactorial(BigInteger n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            int count = 0;
            do
            {
                if (result % 10 == 0)
                {
                    count++;
                    result /= 10;
                }
                else
                {
                    break;
                }
            } while (result > 0);
            return count;
        }
    }
}

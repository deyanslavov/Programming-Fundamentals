namespace _01.Convert_from_base_10_to_base_N
{
    using System;
    using System.Linq;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            var number = input[1].ToString();
            var n = input[0];

            BigInteger temp = 0;
            BigInteger result = 0;

            for (int i = 0; i < number.Length; i++)
            {

                BigInteger chislo = BigInteger.Parse(number[number.Length - 1 - i].ToString());
                temp = chislo * BigInteger.Pow(n, i);
                result += temp;
            }
            Console.WriteLine(result);
        }
    }
}

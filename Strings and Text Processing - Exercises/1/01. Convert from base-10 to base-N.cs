namespace _01.Convert_from_base_10_to_base_N
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            BigInteger number = BigInteger.Parse(input[1]);
            var n = int.Parse(input[0]);
            BigInteger temp = number;
            BigInteger reminder = 0;

            StringBuilder sb = new StringBuilder();

            while (temp > 0)
            {
                reminder = temp - temp % n;
                var difference = temp - reminder;
                temp /= n;
                sb.Append(difference.ToString());
            }
            var result = sb.ToString().Reverse().ToList();
            Console.WriteLine(string.Join("", result));
        }
    }
}

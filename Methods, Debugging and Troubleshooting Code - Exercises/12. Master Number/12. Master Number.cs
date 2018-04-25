namespace _12.Master_Number
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenNum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPalindrome(int num)
        {
            int n = num;
            int dig = 0;
            int rev = 0;
            while (num > 0)
            {
                dig = num % 10;
                rev = rev * 10 + dig;
                num = num / 10;
            }
            if (rev == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool SumOfDigits(int num)
        {
            int n = 0;
            int sum = 0;
            while (num > 0)
            {
                n = num % 10;
                num /= 10;
                sum += n;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ContainsEvenNum(int num)
        {
            int n = 0;
            while (num > 0)
            {
                n = num % 10;
                if (n % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

    }
}

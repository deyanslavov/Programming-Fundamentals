namespace _06.Interval_of_Numbers
{
    using System;

    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = Math.Min(num1,num2); i <= Math.Max(num1, num2); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

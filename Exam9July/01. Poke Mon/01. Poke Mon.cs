namespace _01.Poke_Mon
{
    using System;

    class Program
    {
        static void Main()
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

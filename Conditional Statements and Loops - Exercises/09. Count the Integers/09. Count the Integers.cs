namespace _09.Count_the_Integers
{
    using System;

    class Program
    {
        static void Main()
        {
            int count = 0;

            while (true)
            {
                int num = 0;
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    count++;
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}

namespace _03.Unicode_Characters
{
    using System;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();


            for (int i = 0; i < input.Length; i++)
            {
                var a = String.Format("{0:x}", Convert.ToInt32(input[i]));
                Console.Write("\\u00" + a);
            }
            Console.WriteLine();
        }
    }
}

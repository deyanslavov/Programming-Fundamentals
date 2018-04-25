namespace _03.Miles_to_Kilometers
{
    using System;

    class Program
    {
        static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            double km = miles * 1.60934;

            Console.WriteLine("{0:f2}", km);
        }
    }
}

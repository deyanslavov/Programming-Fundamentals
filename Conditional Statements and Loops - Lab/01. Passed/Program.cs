namespace Conditional_Statements_and_Loops___Lab
{
    using System;

    class Program
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}

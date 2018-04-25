namespace _07.Cake_Ingredients
{
    using System;

    class Program
    {
        static void Main()
        {
            int count = 0;

            do
            {
                string ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    count++;
                    Console.WriteLine("Adding ingredient {0}.", ingredient);
                }
                else
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", count);
                    break;
                }
            } while (true);
        }
    }
}

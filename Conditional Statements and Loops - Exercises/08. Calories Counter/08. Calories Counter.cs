namespace _08.Calories_Counter
{
    using System;

    class Program
    {
        static void Main()
        {
            int numIngredients = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int i = 0; i < numIngredients; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    calories += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingredients == "salami")
                {
                    calories += 600;
                }
                else if (ingredients == "pepper")
                {
                    calories += 50;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Total calories: {0}", calories);
        }
    }
}

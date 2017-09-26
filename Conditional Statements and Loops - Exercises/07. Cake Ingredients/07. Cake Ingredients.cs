using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
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

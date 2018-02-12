using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal pricePerBanana = decimal.Parse(Console.ReadLine());
            decimal pricePerEgg = decimal.Parse(Console.ReadLine());
            decimal pricePerKgBerries = decimal.Parse(Console.ReadLine());
            decimal portions = Math.Ceiling(guests / 6);
            decimal totalPrice = portions * (2.0M * pricePerBanana) + portions * (4.0M * pricePerEgg) + portions * (0.2M * pricePerKgBerries);
            if (totalPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalPrice-cash:f2}lv more.");
            }
        }
    }
}

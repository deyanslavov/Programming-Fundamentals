using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine().ToLower());
            double priceStudio = 0.00;
            double priceDouble = 0.00;
            double priceSuite = 0.00;

            if (month == "may" || month == "october")
            {
                priceStudio = 50;
                priceDouble = 65;
                priceSuite = 75;
                
                if (nightsCount >= 7)
                {
                    priceStudio = priceStudio * 0.95;
                }
                if (month == "october" && nightsCount > 7)
                {
                    nightsCount -= 1;
                }
                Console.WriteLine("Studio: {0:f2} lv.", priceStudio*nightsCount);
                Console.WriteLine("Double: {0:f2} lv.", priceDouble*nightsCount);
                Console.WriteLine("Suite: {0:f2} lv.", priceSuite*nightsCount);
            }
            else if (month == "june" || month == "september")
            {
                priceStudio = 60;
                priceDouble = 72;
                priceSuite = 82;

                if (nightsCount >= 14)
                {
                    priceDouble = priceDouble * 0.90;
                }
                if (month == "september" && nightsCount > 7)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", priceStudio * (nightsCount-1));
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", priceStudio * nightsCount);
                }
                Console.WriteLine("Double: {0:f2} lv.", priceDouble * nightsCount);
                Console.WriteLine("Suite: {0:f2} lv.", priceSuite * nightsCount);
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                priceStudio = 68;
                priceDouble = 77;
                priceSuite = 89;

                if (nightsCount >= 14)
                {
                    priceSuite = priceSuite * 0.85;
                }
                Console.WriteLine("Studio: {0:f2} lv.", priceStudio * nightsCount);
                Console.WriteLine("Double: {0:f2} lv.", priceDouble * nightsCount);
                Console.WriteLine("Suite: {0:f2} lv.", priceSuite * nightsCount);
            }
        }
    }
}

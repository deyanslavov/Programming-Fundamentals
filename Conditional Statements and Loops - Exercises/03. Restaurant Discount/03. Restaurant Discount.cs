namespace _03.Restaurant_Discount
{
    using System;

    class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int priceHall = 0;
            int pricePackage = 0;
            int totalPrice = 0;
            double discount = 0.00;
            double totalPriceWithDiscount = 0;

            if (groupSize <= 50)
            {
                priceHall = 2500;
                if (package == "Normal")
                {
                    discount = 0.05;
                    pricePackage = 500;
                }
                else if (package == "Gold")
                {
                    discount = 0.10;
                    pricePackage = 750;
                }
                else if (package == "Platinum")
                {
                    discount = 0.15;
                    pricePackage = 1000;
                }
                totalPrice = priceHall + pricePackage;
                totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                Console.WriteLine("We can offer you the Small Hall\nThe price per person is {0:f2}$", totalPriceWithDiscount/groupSize);
            }
            else if (groupSize <= 100 && groupSize > 50)
            {
                priceHall = 5000;
                if (package == "Normal")
                {
                    discount = 0.05;
                    pricePackage = 500;
                }
                else if (package == "Gold")
                {
                    discount = 0.10;
                    pricePackage = 750;
                }
                else if (package == "Platinum")
                {
                    discount = 0.15;
                    pricePackage = 1000;
                }
                totalPrice = priceHall + pricePackage;
                totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                Console.WriteLine("We can offer you the Terrace\nThe price per person is {0:f2}$", totalPriceWithDiscount / groupSize);
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                priceHall = 7500;
                if (package == "Normal")
                {
                    discount = 0.05;
                    pricePackage = 500;
                }
                else if (package == "Gold")
                {
                    discount = 0.10;
                    pricePackage = 750;
                }
                else if (package == "Platinum")
                {
                    discount = 0.15;
                    pricePackage = 1000;
                }
                totalPrice = priceHall + pricePackage;
                totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                Console.WriteLine("We can offer you the Great Hall\nThe price per person is {0:f2}$", totalPriceWithDiscount / groupSize);
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}

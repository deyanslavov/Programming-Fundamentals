using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr07AndreyAndBilliard
{
    class Pr07AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> infoItems = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split('-').ToArray();
                string product = info[0];
                decimal price = decimal.Parse(info[1]);

                //премахнах проверката понеже условието не изисква да има такава
                //ако въведат отново такъв продукт цената се презаписва
                infoItems[product] = price;
            }

            string line = string.Empty;
            List<Customer> customers = new List<Customer>();

            while ((line = Console.ReadLine()) != "end of clients")
            {
                string[] infocustomer = line.Split('-');
                string[] orderInfo = infocustomer[1].Split(',');

                if (infoItems.ContainsKey(orderInfo[0]))
                {
                    Customer customer = new Customer();
                    customer.Name = infocustomer[0];

                    int piecesProduct = int.Parse(orderInfo[1]);
                    string product = orderInfo[0];

                    if (customers.Any(c1 => c1.Name == infocustomer[0]))
                    {
                        customer = customers.First(cl => cl.Name == infocustomer[0]);

                        if (!customer.Order.ContainsKey(product))
                        {
                            customer.Order.Add(product, piecesProduct);
                            //забравил си когато добавяш продукти да добавяш и сегашната сума към сметката
                            //ако използваш само знака "=" презаписваш сумата и ако си имал 12.00 лв на сметката
                            //а сега имаш 3.00 ще запишеш 3.00
                            customer.Bill += piecesProduct * infoItems[product];
                        }
                        else
                        {
                            customer.Order[product] += piecesProduct;
                            //тук отново си забравил да добавиш към старата сума новата
                            //и не трябва да умножаваш с "customer.Order[product]", а с "piecesProduct"
                            //ако имаш поръчани 3 бири и 3 коли по 1 лев тоест 6лв общо
                            //ако после се опиташ да добавиш още 3 бири ще ти сметне 6 бири по 1лв и ще обърка цената
                            customer.Bill += piecesProduct * infoItems[product];
                        }
                    }
                    else
                    {
                        customer.Order = new Dictionary<string, int>();

                        customer.Order.Add(product, piecesProduct);
                        customer.Bill = piecesProduct * infoItems[product];
                        customers.Add(customer);
                    }
                }
            }

            decimal sum = 0;
            foreach (var client in customers.OrderBy(cl => cl.Name))
            {
                Console.WriteLine(client.Name);

                foreach (var item in client.Order)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {client.Bill:f2}");

                sum += client.Bill;
            }

            Console.WriteLine($"Total bill: {sum:f2}");
        }
    }

    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> Order { get; set; }

        public decimal Bill { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int n = int.Parse(Console.ReadLine());
                int securityKey = int.Parse(Console.ReadLine());

                decimal siteLoss = 0.0M;

                for (int i = 0; i < n; i++)
                {
                    var websiteData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    var siteName = websiteData[0];
                    decimal siteVisits = decimal.Parse(websiteData[1]);
                    decimal sitePricePerVisit = decimal.Parse(websiteData[2]);

                    Console.WriteLine(siteName);

                    siteLoss = siteLoss + (siteVisits * sitePricePerVisit);
                }
                Console.WriteLine($"Total Loss: {siteLoss:f20}");
                Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey, n)}");
            }
        }
    }
}

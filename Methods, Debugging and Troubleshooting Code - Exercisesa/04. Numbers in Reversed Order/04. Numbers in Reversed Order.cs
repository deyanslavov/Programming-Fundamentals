using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(PrintReversedNum(number));
        }

        static string PrintReversedNum(string numberr)
        {
            string reversedNum = string.Empty;
            for (int i = numberr.Length - 1; i >= 0; i--)
            {
                reversedNum += numberr[i];
            }
            return reversedNum;
        }
    }
}

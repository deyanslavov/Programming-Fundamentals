using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                int num = 0;
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    count++;
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}

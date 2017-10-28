using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();


            for (int i = 0; i < input.Length; i++)
            {
                var a = String.Format("{0:x}", Convert.ToInt32(input[i]));
                Console.Write("\\u00" + a);
            }
            Console.WriteLine();
        }
    }
}

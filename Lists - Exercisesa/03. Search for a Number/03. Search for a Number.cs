using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var newList = new List<int>();
            int numberOfElements = arr[0];
            int numberOfElementsToDelete = arr[1];
            int searchedNumber = arr[2];

            for (int i = 0; i < numberOfElements; i++)
            {
                newList.Add(input[i]);
            }
            for (int i = 0; i < numberOfElementsToDelete; i++)
            {
                newList.RemoveAt(0);
            }
            if (newList.Contains(searchedNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}

namespace _06.Sum_Reversed_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var newList = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                string number = input[i];
                string reversed = reverseTheString(number);
                int num = int.Parse(reversed);
                newList.Add(num);
            }
            Console.WriteLine(newList.Sum());
        }
        private static string reverseTheString(string number)
        {
            char[] arr = number.ToCharArray();
            char[] reversed = arr.Reverse().ToArray();
            string reversedString = string.Join("", reversed);
            return reversedString;
        }
    }
}

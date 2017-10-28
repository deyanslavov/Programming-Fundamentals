using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_fo_equal_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            numbers = Console.ReadLine().Split().Select(a => int.Parse(a)).ToList();
            int bestIndexRight = 0;
            int currIndexRight = 0;
            int bestLengthRight = 0;
            int currLengthRight = 1;
            int valueRight = 0;
            int valueLeft = 0;
            int bestIndexLeft = 0;
            int currIndexLeft = 0;
            int bestLengthLeft = 0;
            int currLengthLeft = 1;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currLengthLeft += 1;
                    if (bestLengthLeft < currLengthLeft)
                    {
                        valueLeft = numbers[i];
                        bestLengthLeft = currLengthLeft;
                        bestIndexLeft = i;
                    }
                }
                else
                {
                    currIndexLeft = i;
                    currLengthLeft = 1;
                }
            }
            for (int i = numbers.Count-1; i > 0; i--)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currLengthRight++;
                    if (bestLengthRight < currLengthRight)
                    {
                        valueRight = numbers[i];
                        bestLengthRight = currLengthRight;
                        bestIndexRight = i;
                    }
                }
                else
                {
                    currIndexRight = i;
                    currLengthRight = 1;
                }
            }
            if (bestLengthLeft >= bestLengthRight)
            {
                for (int i = 0; i < bestLengthLeft; i++)
                {
                    Console.Write(valueLeft + " ");
                }
                Console.WriteLine();
            }
            else if (bestLengthRight == 1 && bestLengthLeft == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = 0; i < bestLengthRight; i++)
                {
                    Console.Write(valueRight + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

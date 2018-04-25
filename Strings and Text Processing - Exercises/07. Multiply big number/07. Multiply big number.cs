namespace _07.Multiply_big_number
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var bigNumber1 = Console.ReadLine().TrimStart(new char[] { '0' });
            int bigNumber2 = int.Parse(Console.ReadLine());
            long reminder = 0;
            long toAdd = 0;
            StringBuilder sb = new StringBuilder();
            if (bigNumber2 == 0 || bigNumber1 == "0" || bigNumber1 == "")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = bigNumber1.Length-1; i >= 0; i--)
            {
                toAdd = int.Parse(bigNumber1[i].ToString()) * bigNumber2 + reminder;
                if (toAdd > 9)
                {
                    if (toAdd > 9 && i == 0)
                    {
                        sb.Insert(0, toAdd);
                    }
                    else
                    {
                        reminder = toAdd / 10;
                        toAdd = toAdd % 10;
                        sb.Insert(0, toAdd);
                    }
                }
                else
                {
                    reminder = 0;
                    sb.Insert(0, toAdd);
                }
            }
            
            Console.WriteLine(string.Join("", sb.ToString().ToArray()));
        }
    }
}

namespace _06.Sum_big_numbers
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var bigNumber1 = Console.ReadLine().TrimStart(new char[] { '0' });
            var bigNumber2 = Console.ReadLine().TrimStart(new char[] { '0' });
            if (bigNumber1.Length > bigNumber2.Length)
            {
                bigNumber2 = bigNumber2.PadLeft(bigNumber1.Length, '0');
            }
            else
            {
                bigNumber1 = bigNumber1.PadLeft(bigNumber2.Length, '0');
            }
            var reminder = 0;
            var toAdd = 0;
            var last = "01";
            StringBuilder sb = new StringBuilder();

            for (int i = bigNumber2.Length - 1; i >= 0; i--)
            {
                toAdd = int.Parse(bigNumber1[i].ToString()) + int.Parse(bigNumber2[i].ToString()) + reminder;
                if (toAdd > 9)
                {
                    if (toAdd > 9 && i == 0)
                    {
                        sb.Append(last);
                    }
                    else
                    {
                        toAdd = toAdd % 10;
                        reminder = 1;
                        sb.Append(toAdd);
                    }
                }
                else
                {
                    reminder = 0;
                    sb.Append(toAdd);
                }
            }
            var result = sb.ToString().Reverse().ToArray();
            Console.WriteLine(string.Join("", (result)));
        }
    }
}

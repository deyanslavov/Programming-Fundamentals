namespace _03.A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var result = new Dictionary<string, long>();
            string key = string.Empty;
            long value = 0;

            for (int i = 1; i > 0; i++)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                if (i % 2 == 1)
                {
                    key = input;
                    if (result.ContainsKey(key))
                    {
                        result[key] += value;
                    }
                    else
                    {
                        key = input;
                        result[key] = value;
                    }
                }
                else
                {                    
                    value = long.Parse(input);
                    if (result.ContainsKey(key))
                    {
                        result[key] += value;
                    }
                    else
                    {
                        result[key] = value;
                    }
                    value = 0;
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}

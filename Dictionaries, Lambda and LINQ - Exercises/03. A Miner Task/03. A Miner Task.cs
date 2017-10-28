using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
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
                        //key = input;
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
                    //result[key] += value;

                    //Console.WriteLine("{0} -> {1}", key, result[key]);
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

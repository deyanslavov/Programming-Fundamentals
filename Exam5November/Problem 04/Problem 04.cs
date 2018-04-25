namespace Problem_04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Data
    {
        public string Key;
        public int Size;

        public Data(string key, int size)
        {
            this.Key = key;
            this.Size = size;
        }
        public Data()
        {

        }
    }
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dataSets = new Dictionary<string, List<Data>>();
            var cache = new Dictionary<string, List<Data>>();

            while (input != "thetinggoesskrra")
            {
                var tokens = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Length == 1)
                {
                    dataSets.Add(tokens[0], new List<Data>());
                    if (cache.ContainsKey(tokens[0]))
                    {
                        dataSets[tokens[0]] = cache[tokens[0]];
                    }
                }
                else
                {
                    var dataKey = tokens[0];
                    var dataSize = int.Parse(tokens[1]);
                    var dataSet = tokens[2];
                    Data data = new Data
                    {
                        Key = dataKey,
                        Size = dataSize
                    };
                    var dataList = new List<Data>();
                    dataList.Add(data);
                    if (dataSets.ContainsKey(dataSet))
                    {
                        dataSets[dataSet].Add(data);
                    }
                    else
                    {
                        if (cache.ContainsKey(dataSet))
                        {
                            cache[dataSet].Add(data);
                        }
                        else
                        {
                            cache.Add(dataSet, dataList);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            var dict = new Dictionary<string, SortedDictionary<int, List<string>>>();

            foreach (var d in dataSets)
            {
                var totalSize = 0;
                var list = new List<string>();
                foreach (var c in d.Value)
                {
                    totalSize += c.Size;

                    list.Add(c.Key);
                }
                var adict = new SortedDictionary<int, List<string>>();
                adict.Add(totalSize, list);
                dict.Add(d.Key, adict);
            }

            PrintResult(dict);
        }

        private static void PrintResult(Dictionary<string, SortedDictionary<int, List<string>>> dict)
        {
            dict.OrderByDescending(d => d.Value.Keys).ThenBy(a => a.Key);
            foreach (var d in dict.Keys)
            {
                Console.Write($"Data Set: {d}, Total Size: ");
                foreach (var a in dict.Values)
                {
                    foreach (var b in a)
                    {
                        Console.WriteLine($"{b.Key}");
                        foreach (var l in b.Value)
                        {
                            Console.WriteLine($"$.{l}");
                        }
                        break;
                    }
                    break;
                }
                break;
            }
        }
    }
}
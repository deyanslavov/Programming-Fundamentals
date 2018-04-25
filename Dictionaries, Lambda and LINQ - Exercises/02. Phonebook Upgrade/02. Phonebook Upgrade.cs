namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                if (input.First() == "A")
                {
                    if (!phonebook.ContainsKey(input[1]))
                    {
                        phonebook[input[1]] = input[2];
                    }
                    else
                    {
                        phonebook[input[1]] = input[2];
                    }
                }
                else if (input.First() == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[1], phonebook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }
                }
                else if (input.First() == "END")
                {
                    break;
                }
                else if (input.First() == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }
                }
                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}

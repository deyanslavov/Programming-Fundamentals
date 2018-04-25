namespace _02.Change_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = new List<int>();
            input = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                var command = Console.ReadLine().Split().ToList();
                if (command[0] == "Odd")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 == 1)
                        {
                            Console.Write(input[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else if (command[0] == "Even")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 == 0)
                        {
                            Console.Write(input[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }

                if (command.Contains("Delete"))
                {                  
                    for (int i = 0; i < input.Count; i++)
                    {
                        input.Remove(int.Parse(command[1]));
                    }
                }
                else if (command.Contains("Insert"))
                {
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            }
        }
    }
}

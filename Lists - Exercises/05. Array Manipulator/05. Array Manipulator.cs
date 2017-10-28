using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToList();
            var command = Console.ReadLine().Split().ToList();
            List<long> final = new List<long>();

            while (command[0] != "print")
            {

                if (command.Contains("add"))
                {
                    input.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command.Contains("addMany"))
                {
                    int index = int.Parse(command[1]);
                    command.RemoveAt(1); command.RemoveAt(0);
                    final = command.Select(long.Parse).ToList();
                    input.InsertRange(index, final);
                }
                else if (command.Contains("contains"))
                {
                    if (input.Contains(int.Parse(command[1])))
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == int.Parse(command[1]))
                            {
                                Console.WriteLine(i);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("-1");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                    
                }
                else if (command.Contains("remove"))
                {
                    input.RemoveAt(int.Parse(command[1]));
                }
                else if (command.Contains("shift"))
                {
                    long last = input.First();
                    for (int i = 0; i < input.Count-1; i++)
                    {                       
                        input[i] = input[i + 1];
                    }
                    input[input.Count - 1] = last;
                }
                else if (command.Contains("sumPairs"))
                {
                    for (int i = 0; i <= input.Count-1; i++)
                    {
                        List<long> newList = new List<long>();
                        if (input.Count % 2 == 1)
                        {
                            newList.Add(input[input.Count - 1]);
                        }
                        input = newList;
                        input[i] = input[i] + input[i + 1];
                        input.RemoveAt(i + 1);
                    }
                }

                command = Console.ReadLine().Split().ToList();

            }
            if (command.Contains("print"))
            {
                Console.WriteLine("[" + string.Join(", ", input) + "]");
            }
        }
    }
}

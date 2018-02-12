using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int fieldSize = int.Parse(Console.ReadLine());
                var indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
                var ladybugs = new long[fieldSize];
                var commandLine = Console.ReadLine();
                for (int i = 0; i < indexes.Count; i++)
                {
                    if (indexes[i] < 0)
                    {
                        indexes.RemoveAt(i);
                    }
                }
                for (int i = 0; i < indexes.Count; i++)
                {
                    ladybugs[indexes[i]] = 1;
                }

                while (commandLine != "end")
                {
                    var tokens = commandLine.Split().ToArray();
                    var ladybugIndex = long.Parse(tokens[0]);
                    var direction = tokens[1];
                    var flyLength = long.Parse(tokens[2]);

                    if (ladybugIndex < 0 || ladybugIndex > ladybugs.Length -1)
                    {
                        commandLine = Console.ReadLine();
                        continue;
                    }

                    if (direction == "right")
                    {
                        if (ladybugIndex < 0 && ladybugIndex > ladybugs.Length - 1)
                        {
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            if (ladybugs[ladybugIndex] == 0)
                            {
                                commandLine = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                if (ladybugIndex > ladybugs.Length - 1)
                                {
                                    commandLine = Console.ReadLine();
                                    continue;
                                }
                                else if (ladybugIndex + flyLength > ladybugs.Length - 1)
                                {
                                    ladybugs[ladybugIndex] = 0;
                                    commandLine = Console.ReadLine();
                                    continue;
                                }
                                else
                                {
                                    if (ladybugIndex + flyLength > ladybugs.Length - 1)
                                    {
                                        ladybugs[ladybugIndex] = 0;
                                        commandLine = Console.ReadLine();
                                        continue;
                                    }
                                    else
                                    {
                                        if (ladybugs[ladybugIndex + flyLength] == 0)
                                        {
                                            ladybugs[ladybugIndex + flyLength] = 1;
                                            ladybugs[ladybugIndex] = 0;
                                        }
                                        else
                                        {
                                            long freeLadybugIndex = ladybugIndex;
                                            for (long i = ladybugIndex + flyLength; i < ladybugs.Length; i++)
                                            {
                                                if (ladybugs[i] == 1)
                                                {
                                                    continue;
                                                }
                                                else
                                                {
                                                    freeLadybugIndex = i;
                                                    break;
                                                }
                                            }

                                            ladybugs[freeLadybugIndex] = 1;
                                            ladybugs[ladybugIndex] = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        if (ladybugIndex < 0 && ladybugIndex > ladybugs.Length - 1)
                        {
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            if (ladybugs[ladybugIndex] == 0)
                            {
                                commandLine = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                if (ladybugIndex < 0)
                                {
                                    commandLine = Console.ReadLine();
                                    continue;
                                }
                                else if (ladybugIndex - flyLength < 0)
                                {
                                    ladybugs[ladybugIndex] = 0;
                                    commandLine = Console.ReadLine();
                                    continue;
                                }
                                else
                                {
                                    if (ladybugIndex - flyLength < 0)
                                    {
                                        ladybugs[ladybugIndex] = 0;
                                        commandLine = Console.ReadLine();
                                        continue;
                                    }
                                    else
                                    {
                                        if (ladybugs[ladybugIndex - flyLength] == 0)
                                        {
                                            ladybugs[ladybugIndex - flyLength] = 1;
                                            ladybugs[ladybugIndex] = 0;
                                        }
                                        else
                                        {
                                            long freeLadybugIndex = ladybugIndex;
                                            for (long i = ladybugIndex - 1; i >= 0; i--)
                                            {
                                                if (ladybugs[i] == 1)
                                                {
                                                    continue;
                                                }
                                                else
                                                {
                                                    freeLadybugIndex = i;
                                                    break;
                                                }
                                            }

                                            ladybugs[freeLadybugIndex] = 1;
                                            ladybugs[ladybugIndex] = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    commandLine = Console.ReadLine();
                }
                Console.WriteLine(string.Join(" ", ladybugs));
            }
        }
    }
}

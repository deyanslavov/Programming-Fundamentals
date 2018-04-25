namespace Problem_02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToList();

            var commandLine = Console.ReadLine();

            while (commandLine != "3:1")
            {

                var tokens = commandLine.Split().ToList();

                if (tokens[0] == "merge")
                {
                    var command = tokens[0];
                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex > input.Count - 1)
                    {
                        commandLine = Console.ReadLine();
                        continue;
                    }
                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }
                    StringBuilder sb = new StringBuilder();
                    for (int i = startIndex; i < endIndex + 1; i++)
                    {
                        sb.Append(input[i]);
                    }

                    input.Insert(endIndex + 1, sb.ToString());
                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    sb.Clear();
                    commandLine = Console.ReadLine();
                }
                else if (tokens[0] == "divide")
                {
                    var command = tokens[0];
                    var index = int.Parse(tokens[1]);
                    var partition = int.Parse(tokens[2]);

                    var toAdd = new List<string>();
                    string element = "";
                    var lettersCountToRemove = input[index].Length / partition;
                    if (lettersCountToRemove == 0)
                    {
                        lettersCountToRemove = 1;
                    }
                    if (input[index].Length == 1 || input[index].Length <= lettersCountToRemove)
                    {
                        element = input[index];
                        toAdd.Add(element);
                    }
                    else
                    {
                        var letterCount = 0;
                        var length = input[index].Length / partition;
                        if (length < 1)
                        {
                            length = 1;
                        }
                        for (int i = 0; i < partition * lettersCountToRemove; i += lettersCountToRemove)
                        {
                            if (i == partition*lettersCountToRemove - 1)
                            {
                                if (i >= input[index].Length)
                                {
                                    i = input[index].Length - 1;
                                    element = input[index].Substring(i, length);
                                    toAdd.Add(element);
                                    break;
                                }
                                else
                                {
                                    element = input[index].Substring(i, length);
                                    toAdd.Add(element);
                                }
                            }
                            else
                            {
                                element = input[index].Substring(i, length);
                                toAdd.Add(element);
                                letterCount += element.Length;
                                if (input[index].Length - length == 1)
                                {
                                    i = partition * letterCount - 2;
                                }
                            }                           
                        }
                    }

                    input.InsertRange(index + 1, toAdd);
                    input.RemoveRange(index, 1);
                    commandLine = Console.ReadLine();
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

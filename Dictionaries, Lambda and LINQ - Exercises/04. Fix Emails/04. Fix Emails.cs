namespace _04.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var result = new Dictionary<string, string>();
            string name = string.Empty;
            string email = string.Empty;

            for (int i = 1; i > 0; i++)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                if (i % 2 == 1)
                {
                    name = input;
                    result[name] = "";
                }
                else
                {
                    email = input;
                    result[name] = email;
                    var lastLetters = result[name].Reverse().Take(2).ToArray();
                    if ((lastLetters[0] == 'k' && lastLetters[1] == 'u') || (lastLetters[0] == 's' && lastLetters[1] == 'u'))
                    {
                        result.Remove(name);
                    }
                    name = "";
                    email = "";
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}

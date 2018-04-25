namespace _04.Cubic_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main()
        {
            Dictionary<string, string> result = ReadAndProcessInput();
            PrintResult(result);
        }

        private static void PrintResult(Dictionary<string, string> result)
        {
            foreach (var r in result)
            {
                Console.WriteLine($"{r.Key} == {r.Value}");
            }
        }

        private static Dictionary<string, string> ReadAndProcessInput()
        {
            var encryptedMessage = Console.ReadLine();
            var result = new Dictionary<string, string>();

            while (encryptedMessage != "Over!")
            {
                int m = int.Parse(Console.ReadLine());
                int digitCount = 0;
                var indices = new List<int>();
                indices = TryParseMessage(encryptedMessage, digitCount, indices);
                digitCount = indices.Count;
                var messageToDecrypt = encryptedMessage.Substring(digitCount, m);
                var afterMessage = encryptedMessage.Substring(encryptedMessage.IndexOf(messageToDecrypt) + m);


                bool includesLetter = false;
                for (int i = 0; i < afterMessage.Length; i++)
                {
                    if (char.IsUpper(afterMessage[i]) || char.IsLower(afterMessage[i]))
                    {
                        includesLetter = true;
                        break;
                    }
                }

                if (char.IsDigit(encryptedMessage[0]) && messageToDecrypt.Length == m && !includesLetter)
                {
                    indices = TryParseMessage(afterMessage, digitCount, indices);

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < indices.Count; i++)
                    {
                        if (indices[i] > messageToDecrypt.Length - 1)
                        {
                            sb.Append(" ");
                        }
                        else
                        {
                            sb.Append(messageToDecrypt[indices[i]]);
                        }
                    }
                    result.Add(messageToDecrypt, sb.ToString());
                }

                encryptedMessage = Console.ReadLine();
            }

            return result;
        }

        private static List<int> TryParseMessage(string encryptedMessage, int digitCount, List<int> indices)
        {
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if (int.TryParse(encryptedMessage[i].ToString(), out int n))
                {
                    indices.Add(n);
                    digitCount++;
                }
                else
                {
                    break;
                }
            }

            return indices;
        }
    }
}

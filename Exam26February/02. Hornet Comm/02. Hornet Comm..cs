using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Hornet_Comm
{
    class Message
    {
        public string Code;
        public string Mes;

        public Message(string code, string mes)
        {
            this.Code = code;
            this.Mes = mes;
        }
        public Message()
        {

        }
    }
    class Broadcast
    {
        public string Frequency;
        public string Mes;

        public Broadcast(string frequency, string mes)
        {
            this.Frequency = frequency;
            this.Mes = mes;
        }
        public Broadcast()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                var input = Console.ReadLine();
                char[] splitters = { ' ', '-', '>', '<' };
                var messageList = new List<Message>();
                var broadcastList = new List<Broadcast>();
                while (input != "Hornet is Green")
                {
                    Message message = new Message();

                    Broadcast broadcast = new Broadcast();
                    var splittedInput = Regex.Split(input, " <-> ").ToArray();
                    if (splittedInput.Length == 1)
                    {
                        input = Console.ReadLine();
                            break;
                    }
                    var splittedInput1 = splittedInput[0].ToCharArray();
                    var splittedInput2 = splittedInput[1].ToCharArray();
                    bool ContainsOnlyDigit = true;
                    bool ContainsDigitsAndLetter = true;
                    bool DoesNotContainDigit = true;
                    for (int i = 0; i < splittedInput1.Length; i++)
                    {
                        if (!char.IsDigit(splittedInput1[i]))
                        {
                            ContainsOnlyDigit = false;
                        }
                        else
                        {
                            DoesNotContainDigit = false;
                        }
                    }
                    for (int i = 0; i < splittedInput2.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(splittedInput2[i]))
                        {
                            ContainsDigitsAndLetter = false;
                            break;
                        }
                    }
                    if (ContainsDigitsAndLetter && ContainsOnlyDigit)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = splittedInput1.Length - 1; i >= 0; i--)
                        {
                            sb.Append(splittedInput1[i]);
                        }
                        message.Code = sb.ToString();
                        message.Mes = splittedInput[1];
                        messageList.Add(message);
                    }
                    else if (DoesNotContainDigit && ContainsDigitsAndLetter)
                    {
                        StringBuilder sb = new StringBuilder();
                        var freq = splittedInput[1].ToCharArray();
                        for (int i = 0; i < freq.Length; i++)
                        {
                            if (char.IsUpper(freq[i]))
                            {
                                sb.Append(char.ToLower(freq[i]));
                            }
                            else if (char.IsLower(freq[i]))
                            {
                                sb.Append(char.ToUpper(freq[i]));
                            }
                            else
                            {
                                sb.Append(freq[i]);
                            }
                        }
                        broadcast.Mes = splittedInput[0];
                        broadcast.Frequency = sb.ToString();
                        broadcastList.Add(broadcast);
                    }
                    input = Console.ReadLine();
                }
                Console.WriteLine("Broadcasts:");
                if (broadcastList.Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var b in broadcastList)
                    {
                        Console.WriteLine($"{string.Join("", b.Frequency)} -> {b.Mes}");
                    }

                }
                Console.WriteLine("Messages:");
                if (messageList.Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var m in messageList)
                    {
                        Console.WriteLine($"{m.Code} -> {m.Mes}");
                    }
                }
            }
        }
    }
}

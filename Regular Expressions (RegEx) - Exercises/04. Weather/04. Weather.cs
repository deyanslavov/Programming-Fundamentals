using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class WeatherInfo
    {
        public double Temperature { get; set; }
        public string Weather { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<town>[A-Z]{2})(?<temp>[\d]+\.[\d]+)(?<weather>[a-zA-Z]+)\|";
            var result = new Dictionary<string, WeatherInfo>();
            
            var input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            while (true)
            {
                if (input == "end")
                {
                    break;
                }
                var match = regex.Match(input);
                if (match.Success)
                {
                    var town = match.Groups["town"].ToString();
                    var temperature = double.Parse(match.Groups["temp"].ToString());
                    var weather = match.Groups["weather"].ToString();

                    var info = new WeatherInfo { Temperature = temperature, Weather = weather };

                    result[town] = info;
                    input = Console.ReadLine();
                }
                else
                {
                    input = Console.ReadLine();
                }
            }
            var sorted = result.OrderBy(a => a.Value.Temperature);
            foreach (var a in sorted)
            {
                Console.WriteLine($"{a.Key} => {a.Value.Temperature} => {a.Value.Weather}");
            }            
        }
    }
}

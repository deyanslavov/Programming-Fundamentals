using System;
using System.Collections.Generic;
using System.Linq;

class Evolution
{
    public string Name { get; set; }
    public int Index { get; set; }

    public List<Evolution> evolutions;

    public List<Evolution> GetEvolutions()
    {
        return evolutions;
    }

    public void SetEvolutions(List<Evolution> value)
    {
        evolutions = value;
    }

    public Evolution(string name, int index, List<Evolution> evolutions)
    {
        this.Name = name;
        this.Index = index;
        this.SetEvolutions(evolutions);
    }

    public Evolution()
    {
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<Evolution>> pokemons = ReadAndProcessInput();
        PrintResult(pokemons);
    }

    private static Dictionary<string, List<Evolution>> ReadAndProcessInput()
    {
        var input = Console.ReadLine();
        var pokemons = new Dictionary<string, List<Evolution>>();

        while (input != "wubbalubbadubdub")
        {
            var splitInput = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (splitInput.Length == 1 && pokemons.ContainsKey(splitInput[0]))
            {
                var pokemonName = splitInput[0];
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine($"# {pokemonName}");
                    var key = pokemons[pokemonName];
                    foreach (var k in key)
                    {
                        Console.WriteLine($"{k.Name} <-> {k.Index}");
                    }
                }
            }
            else
            {
                var pokemonName = splitInput[0];
                Evolution evolution = new Evolution();
                evolution.Name = splitInput[1];
                evolution.Index = int.Parse(splitInput[2]);
                var evolutions = new List<Evolution>();
                evolutions.Add(evolution);

                if (!pokemons.ContainsKey(pokemonName))
                {
                    pokemons[pokemonName] = evolutions;
                }
                else
                {
                    pokemons[pokemonName].Add(evolution);
                }
            }
            input = Console.ReadLine();
        }

        return pokemons;
    }

    private static void PrintResult(Dictionary<string, List<Evolution>> pokemons)
    {
        foreach (var p in pokemons)
        {
            Console.WriteLine($"# {p.Key}");
            foreach (var e in p.Value.OrderByDescending(x => x.Index))
            {
                Console.WriteLine($"{e.Name} <-> {e.Index}");
            }
        }
    }
}


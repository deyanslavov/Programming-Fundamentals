namespace _02.Pokemon_Don_t_Go
{
    using System;
    using System.Linq;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            var pokemons = Console.ReadLine().Split().Select(long.Parse).ToList();
            BigInteger sum = 0;
            sum = CalculateSum(pokemons, sum);
            Console.WriteLine(sum);
        }

        private static BigInteger CalculateSum(System.Collections.Generic.List<long> pokemons, BigInteger sum)
        {
            while (pokemons.Count != 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());
                if (indexToRemove > pokemons.Count - 1)
                {
                    indexToRemove = pokemons.Count - 1;
                    pokemons[pokemons.Count - 1] = pokemons.First();
                    var digit = pokemons[pokemons.Count - 1];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] > digit)
                        {
                            pokemons[i] -= digit;
                        }
                        else if (pokemons[i] <= digit)
                        {
                            pokemons[i] += digit;
                        }
                    }
                    sum += digit;
                }
                else if (indexToRemove < 0)
                {
                    pokemons[0] = pokemons.Last();
                    var digit = pokemons[0];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] > digit)
                        {
                            pokemons[i] -= digit;
                        }
                        else if (pokemons[i] <= digit)
                        {
                            pokemons[i] += digit;
                        }
                    }
                    sum += digit;
                }
                else
                {
                    var digit = pokemons[indexToRemove];
                    pokemons.RemoveAt(indexToRemove);
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] > digit)
                        {
                            pokemons[i] -= digit;
                        }
                        else if (pokemons[i] <= digit)
                        {
                            pokemons[i] += digit;
                        }
                    }
                    sum += digit;
                }
            }

            return sum;
        }
    }
}

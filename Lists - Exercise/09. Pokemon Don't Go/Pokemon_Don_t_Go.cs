using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    public class Pokemon_Don_t_Go
    {
        public static void Main()
        {
            List<int> distToPokemons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> removed = new List<int>();
            while (true)
            {
                if (distToPokemons.Count == 0)
                {
                    break;
                }

                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    distToPokemons[0] = distToPokemons[distToPokemons.Count - 1];

                    index = 0;
                    removed.Add(distToPokemons[index]);
                    ProccessElements(distToPokemons[index], distToPokemons);
                    continue;
                }

                if (index > distToPokemons.Count - 1)
                {
                    distToPokemons[distToPokemons.Count - 1] = distToPokemons[0];

                    index = distToPokemons.Count - 1;
                    removed.Add(distToPokemons[index]);
                    ProccessElements(distToPokemons[index], distToPokemons);
                    continue;
                }

                int elementToRemove = distToPokemons[index];
                distToPokemons.RemoveAt(index);
                removed.Add(elementToRemove);
                ProccessElements(elementToRemove, distToPokemons);
            }

            checked
            {
                int sum = removed.Sum();
                Console.WriteLine(sum);
            }
        }

        private static void ProccessElements(int elementToRemove, List<int> distToPokemons)
        {
            for (int i = 0; i < distToPokemons.Count; i++)
            {
                int currentElement = distToPokemons[i];
                if (currentElement <= elementToRemove)
                {
                    distToPokemons[i] += elementToRemove;
                }
                else
                {
                    distToPokemons[i] -= elementToRemove;
                }
            }
        }
    }
}

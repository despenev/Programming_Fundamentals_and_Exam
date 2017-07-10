using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pokemon_Evolution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var pokemonsList = new List<Pokemon>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input=="wubbalubbadubdub")
                {
                    break;
                }
                var tokens = input.Split(new[]{'-','>'},StringSplitOptions.RemoveEmptyEntries).ToList();

                var name = tokens[0].Trim();
				if (tokens.Count==1)
				{
					if (pokemonsList.Any(x=>x.Name==name))
					{
                        var pokeIndex = pokemonsList.FindIndex(x => x.Name == name);

                        Console.WriteLine($"# {name}");
                        for (int i = 0; i < pokemonsList[pokeIndex].EvoAndIndex.Count; i++)
                        {
                            Console.WriteLine("{0} <-> {1}",pokemonsList[pokeIndex].EvoAndIndex[i].Key,pokemonsList[pokeIndex].EvoAndIndex[i].Value);
                        }
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                var evolutionType = tokens[1].Trim();
                var evolutionIndex = int.Parse(tokens[2].Trim());
                var evoTypeIndex = new KeyValuePair<string, int>(evolutionType, evolutionIndex);

                if (!pokemonsList.Any(x=>x.Name==name))
                {
                    var pokemon = new Pokemon
                    {
                        Name = name,
                        EvoAndIndex = new List<KeyValuePair<string, int>>()
                        {
                            evoTypeIndex
                        }
                     };
                    pokemonsList.Add(pokemon);
                }
                else
                {
                    var pokeIndex = pokemonsList.FindIndex(x => x.Name == name);
                    pokemonsList[pokeIndex].EvoAndIndex.Add(evoTypeIndex);

                }



            }

            foreach (var p in pokemonsList)
            {
                Console.WriteLine($"# {p.Name}");

                foreach (var evo in p.EvoAndIndex.OrderByDescending(x=>x.Value).ThenBy(a=>a.Key))
                {
                    Console.WriteLine("{0} <-> {1}", evo.Key,evo.Value);
                }

            }
        }
        class Pokemon
        {
            public string Name { get; set; }
            public List<KeyValuePair<string, int>> EvoAndIndex { get; set;}

        }
    }
}

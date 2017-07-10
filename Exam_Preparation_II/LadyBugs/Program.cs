using System;
using System.Collections.Generic;
using System.Linq;


namespace LadyBugs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();

            ladybugIndexes = ladybugIndexes.Where(x => x < fieldSize).Where(x => x >= 0).ToList();

            var tokens = Console.ReadLine().Split().ToList();

            while (tokens[0] != "end")
            {
                var index = int.Parse(tokens[0]);
                if (!ladybugIndexes.Contains(index))
                {
                    tokens = Console.ReadLine().Split().ToList();
                    continue;
                }
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);

                if (direction == "right")
                {
                    var newIndex = index + flyLength;
                    ladybugIndexes.Remove(index);

                    if (newIndex < fieldSize &&
                        !ladybugIndexes.Contains(newIndex) &&
                       newIndex >= 0)
                    {
                        ladybugIndexes.Add(newIndex);
                    }
                    else if (newIndex < fieldSize && 
                             ladybugIndexes.Contains(newIndex) &&
                             newIndex>=0)
                    {
                        while (ladybugIndexes.Contains(newIndex))
                        {
                            newIndex += flyLength;
                        }
                        if (newIndex >= fieldSize ||
                            newIndex<0)
                        {
                            tokens = Console.ReadLine().Split().ToList();
                            continue;
                        }
                        ladybugIndexes.Add(newIndex);
                    }

                }
                if (direction == "left")
                {
                    var newIndex = index - flyLength;
                    ladybugIndexes.Remove(index);

                    if (newIndex >= 0 &&
                        !ladybugIndexes.Contains(newIndex) &&
                        newIndex < fieldSize)
					{
						ladybugIndexes.Add(newIndex);
					}
					else if (newIndex >= 0 &&
                             ladybugIndexes.Contains(newIndex) &&
                             newIndex < fieldSize)
					{
						while (ladybugIndexes.Contains(newIndex))
						{
							newIndex -= flyLength;
						}
                        if (newIndex >= fieldSize ||
                            newIndex<0)
						{
							tokens = Console.ReadLine().Split().ToList();
							continue;
						}
						ladybugIndexes.Add(newIndex);
					}

                }
				tokens = Console.ReadLine().Split().ToList();

            }

            for (int i = 0; i < fieldSize; i++)
            {
                if (ladybugIndexes.Contains(i))
                {
                    Console.Write("1 ");
                }
                else Console.Write("0 ");
            }
        }
    }
}

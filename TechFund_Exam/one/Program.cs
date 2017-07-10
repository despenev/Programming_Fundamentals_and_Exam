using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Dont_Go
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a=>int.Parse(a)).ToList();
            var backupList = new List<int>();
            var sumOfRemoved = 0;
            while (input.Count>0)
            {
                var index = int.Parse(Console.ReadLine());
                if (index >= 0 && index < input.Count)
                {
                    sumOfRemoved += input[index];
                    var removed = input[index];
                    input.RemoveAt(index);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i]<=removed)
                        {
                            input[i] = input[i] + removed;
                        }
                        else
                        {
                            input[i] = input[i] - removed;
                        }
                    }

                }
                else if(index<0)
                {
                    sumOfRemoved += input[0];
                    var removed = input[0];
                    input[0] = input[input.Count - 1];

					for (int i = 0; i < input.Count; i++)
					{
						if (input[i] <= removed)
						{
							input[i] = input[i] + removed;
						}
						else
						{
							input[i] = input[i] - removed;
						}
					}
                }
                else
                {
                    sumOfRemoved += input[input.Count - 1];
                    var removed = input[input.Count - 1];
                    input[input.Count - 1] = input[0];
					for (int i = 0; i < input.Count; i++)
					{
						if (input[i] <= removed)
						{
							input[i] = input[i] + removed;
						}
						else
						{
							input[i] = input[i] - removed;
						}
					}

                }

            }

            Console.WriteLine(sumOfRemoved);
        }
    }
}

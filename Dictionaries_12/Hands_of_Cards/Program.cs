using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_of_Cards
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var people = new Dictionary<string, List<string>>();
			while (true)
			{
				//var separators = new List<char> {':',' ',',' };
				var input = new List<string>();
				input = Console.ReadLine().Split(new char[] { ':', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
				var cards = new List<string>();
				for (int i = 1; i < input.Count; i++)
				{
					if (input[i] != null)
						cards.Add(input[i]);
					
				}

				if (input[0] == "JOKER")
				{
					//foreach (var item in people)
					//{
					//	Console.Write(item.Key + " ");
					//	for (int i = 0; i < people[item.Key].Count; i++)
					//	{
					//		Console.Write(item.Value[i] + " ");
					//	}
					//}
					var result = 0;
					var left = 1;
					var right = 1;
					foreach (var item in people)
					{
						result = 0;
						left = 1;
						right = 1;
						for (int i = 0; i < item.Value.Count; i++)
						{
							var card = item.Value[i].ToCharArray();
							switch (card[0])
							{
								case '2':
									{
										left = 2;
										break;
									}
								case '3':
									{
										left = 3;
										break;
									}
								case '4':
									{
										left = 4;
										break;
									}
								case '5':
									{
										left = 5;
										break;
									}
								case '6':
									{
										left = 6;
										break;
									}
								case '7':
									{
										left = 7;
										break;
									}
								case '8':
									{
										left = 8;
										break;
									}
								case '9':
									{
										left = 9;
										break;
									}
								case '1':
									{
										left = 10;
										break;
									}
								case 'J':
									{
										left = 11;
										break;
									}
								case 'Q':
									{
										left = 12;
										break;
									}
								case 'K':
									{
										left = 13;
										break;
									}
								case 'A':
									{
										left = 14;
										break;
									}

							}
							switch (card[1])
							{
								case 'S':
									{
										right = 4;
										break;
									}
								case 'H':
									{
										right = 3;
										break;
									}
								case 'D':
									{
										right = 2;
										break;
									}
								case 'C':
									{
										right = 1;
										break;
									}
								case '0':
									{
										switch (card[2])
										{
											case 'S':
												{
													right = 4;
													break;
												}
											case 'H':
												{
													right = 3;
													break;
												}
											case 'D':
												{
													right = 2;
													break;
												}
											case 'C':
												{
													right = 1;
													break;
												}
										}
										break;
									}
							}
							result += left * right;
						}
						Console.WriteLine($"{item.Key}: {result}");

					}
					return;
				}
					if (!people.ContainsKey(input[0]))
					{
						people[input[0]] = cards;
					}
					else
					{
						for (int i = 1; i < input.Count; i++)
						{
							if (!people[input[0]].Contains(input[i]))
								people[input[0]].Add(input[i]);
						}
					}

				}
			}
		}
	}


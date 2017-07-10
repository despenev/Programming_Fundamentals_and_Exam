using System;
using System.Collections.Generic;
using System.Linq;

namespace Karaoke
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var participants = Console.ReadLine().
			                          Split(new char[] { ',',' ' },StringSplitOptions.RemoveEmptyEntries).
			                          ToList();
			var songs = Console.ReadLine().
			                   Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries).

			                   ToList();

			var participantsDict = new Dictionary<string, List<string>>();
			foreach (var p in participants)
			{
				participantsDict[p] = new List<string>();
			}

			while (true)
			{
			var tokens = Console.ReadLine().
				                Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries).
				                Select(a => a.Trim()).
				                ToList();
				if (tokens[0]=="dawn")
				{
					if (participantsDict.All(x=>x.Value.Count==0))
					{
						Console.WriteLine("No awards");
						return;
					}
					foreach (var p in participantsDict.
					         Where(a=>a.Value.Count!=0).
					         OrderByDescending(a=>a.Value.Count).
					         ThenBy(a=>a.Key))
						                                         
					{
						Console.WriteLine($"{p.Key}: {p.Value.Count} awards");

						foreach (var aw in p.Value)
						{
							Console.WriteLine($"--{aw}");
						}
					}
					return;
				}
				var name = tokens[0];
				var song = tokens[1];
				var award = "";
				if (tokens.Count==3)
				{
					award = tokens[2];
				}

				if (participantsDict.ContainsKey(name) && 
				    songs.Contains(song) && award!="" &&
				    !participantsDict[name].Contains(award))
														participantsDict[name].Add(award);
				
			}


		}
	}
}

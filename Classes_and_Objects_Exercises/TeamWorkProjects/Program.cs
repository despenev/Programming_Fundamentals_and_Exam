using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace ObjectsAndClasses
{
	class Program
	{
		class Team
		{
			public string TeamName { get; set; }
			public List<string> Members { get; set; }
			public string CreatorName { get; set; }
		}
		static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var teamlist = new List<Team>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split('-');
				var creatorname = input[0];
				var teamname = input[1];
				if (!teamlist.Any(x => x.CreatorName == creatorname) && !teamlist.Any(x => x.TeamName == teamname))
				{
					teamlist.Add(new Team()
					{
						CreatorName = creatorname,
						TeamName = teamname,
						Members = new List<string>()

					});
					Console.WriteLine($"Team {teamname} has been created by {creatorname}!");
				}
				else
				{
					if (teamlist.Any(x => x.TeamName == teamname))
					{
						Console.WriteLine($"Team {teamname} was already created!");
					}
					if (teamlist.Any(x => x.CreatorName == creatorname))
					{
						Console.WriteLine($"{creatorname} cannot create another team!");
					}
				}
			}
			while (true)
			{
				var input = Console.ReadLine().Split(new char[] { '-', '>', }, StringSplitOptions.RemoveEmptyEntries).ToList();
				if (input[0] == "end of assignment")
				{
					//teamlist.Sort((emp1, emp2) => emp1.Members.Count.CompareTo(emp2.Members.Count));
					var sortedteamlist = teamlist.OrderByDescending(a => a.Members.Count).ThenBy(a => a.Members).ToList();


					foreach (var currentTeam in sortedteamlist)
					{
						{
							if (currentTeam.Members.Count != 0)
							{
								Console.WriteLine(currentTeam.TeamName);
								Console.WriteLine($"- {currentTeam.CreatorName}");
								foreach (var currentUser in currentTeam.Members.OrderBy(x => x))
								{
									Console.WriteLine($"-- {currentUser}");
								}

							}
						}
					}
					foreach (var currentTeam in sortedteamlist)
					{
						if (currentTeam.Members.Count == 0)
						{


							Console.WriteLine($"-- {currentTeam.Members}");
						}
					}



					Console.WriteLine("Teams to disband:");
					foreach (var currentTeam in sortedteamlist.OrderBy(x=>x.TeamName))
					{
						if (currentTeam.Members.Count==0)
						{
							Console.WriteLine($"{currentTeam.TeamName}");
						}
					}
					return;
				}

				string teammember = input[0];
				string teamname = input[1];
				if (!teamlist.Any(x => x.TeamName == teamname))
				{
					Console.WriteLine($"Team {teamname} does not exist!");
				}
				else if (teamlist.Any(x => x.Members.Any(y => y == teammember)) || teamlist.Any(x => x.CreatorName== teammember))
				{
					Console.WriteLine($"Member {teammember} cannot join team {teamname}!");
				}
				else
				{
					int index = teamlist.FindIndex(a => a.TeamName == teamname);

					teamlist[index].Members.Add(teammember);
				}
			}
		}
	}
}

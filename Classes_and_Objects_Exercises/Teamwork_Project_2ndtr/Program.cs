using System;
using System.Collections.Generic;
using System.Linq;


namespace Teamwork_Project_2ndtr
{
	class MainClass
	{
		class Team
		{
			public string TeamName { get; set; }
			public List<string> Members { get; set; }
			public string Creator { get; set; }
		}

		public static void Main(string[] args)
		{
			var num = int.Parse(Console.ReadLine());
			var teamList = new List<Team>();

			for (int i = 0; i < num; i++)
			{
				var tokens = Console.ReadLine().Split('-').ToList();
				var creator = tokens[0];
				var teamName = tokens[1];


				 if (teamList.Any(x => x.TeamName == teamName))
				{
					Console.WriteLine($"Team {teamName} was already created!");
				}
				else if (teamList.Any(x => x.Creator == creator))
				{
					Console.WriteLine($"{creator} cannot create another team!");
				}
				else
				{
					var team = new Team()
					{
						Creator = creator,
						TeamName = teamName,
						Members = new List<string>()
					};
					teamList.Add(team);
					Console.WriteLine($"Team {teamName} has been created by {creator}!");
				}
			}

			while (true)
			{
				var tokens = Console.ReadLine().Split(new char[] { '-', '>'},StringSplitOptions.RemoveEmptyEntries).ToList();

				if (tokens[0]=="end of assignment")
				{
					foreach (var team in teamList.Where(x=>x.Members.Count>0).OrderByDescending(x=>x.Members.Count).ThenBy(x=>x.TeamName))
					{
						Console.WriteLine($"{team.TeamName}\n- {team.Creator}");

						foreach (var person in team.Members.OrderBy(x=>x))
						{
							Console.WriteLine($"-- {person}");
						}
					}

						Console.WriteLine($"Teams to disband:");

						foreach (var team in teamList.Where(x=>x.Members.Count==0).OrderBy(x=>x.TeamName))
						{
							Console.WriteLine($"{team.TeamName}");
						}

					return;
				}

				var member = tokens[0];
				var teamName = tokens[1];

				if (!teamList.Any(x => x.TeamName == teamName))
				{
					Console.WriteLine($"Team {teamName} does not exist!");
				}
				else if (teamList.Any(x => x.Members.Any(y => y == member)) || teamList.Any(x => x.Creator == member))
				{
					Console.WriteLine($"Member {member} cannot join team {teamName}!");
				}
				else 
				{
					//teamList.Where(x => x.TeamName == teamName).Select( x=>x.Members.Add(member));

					var index = teamList.FindIndex(x => x.TeamName == teamName);
					teamList[index].Members.Add(member);
				}

			}



		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;


namespace User_Logs
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var users = new SortedDictionary<string, Dictionary<string, int>>();

			while (true)
			{
				var input = Console.ReadLine().Split(new char[] { '=', '\'', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				if (input[0] == "end")
				{
					foreach (var user in users)
					{
						Console.WriteLine(user.Key + ": ");
						var IPs = user.Value;
						var iP = IPs.Select(x => x.Key).ToList();
						var count = IPs.Select(x => x.Value).ToList();
						foreach (var IP in IPs)
						{
							if (IP.Key != user.Value.Keys.Last())
								Console.Write(IP.Key + " => " + IP.Value + ", ");
							else Console.WriteLine(IP.Key + " => " + IP.Value + ".");
						}

					}
					return;
				}
				var ip = input[1];
				string username;
				try { username = input[5]; }
				catch (System.ArgumentOutOfRangeException) { username = input[4]; }

				if (!users.ContainsKey(username))
				{
					users[username] = new Dictionary<string, int>();
				}
				if (!users[username].ContainsKey(ip))
				{
					users[username][ip] = 0;
				}
				users[username][ip] += 1;
			}
		}
	}
}


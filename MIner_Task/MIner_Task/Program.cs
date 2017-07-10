using System;
using System.Linq;
using System.Collections.Generic;


namespace MIner_Task
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var storage = new Dictionary<string, int>();
			var list = new List<string>();
			var nums = new List<int>();
			var laino = 0;
			var pass = true;
			while (pass)
			{
				var duma = Console.ReadLine();
				if (duma == "stop") break;
				list.Add(duma);
				var chislo = int.Parse(Console.ReadLine());
				nums.Add(chislo);

				if (!storage.ContainsKey(list[laino]))
							storage[list[laino]] = nums[laino];
				else storage[list[laino]] += nums[laino];


				laino++;
			}

			foreach (KeyValuePair<string,int> item in storage)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}





		}
	}
}

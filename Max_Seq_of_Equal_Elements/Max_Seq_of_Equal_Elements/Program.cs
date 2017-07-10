using System;
using System.Linq;
using System.Collections.Generic;
namespace Max_Seq_of_Equal_Elements
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
			var len = new List<int>(nums.Count);
			var left = -1;
			var prev = new List<int>();
			var LIS = new List<List<int>>();

			for (int i = 0; i < nums.Count; i++)
			{
				if (left == -1)
					len.Add(1);

				else 
					len[i] = 1 + len[left];

				prev.Add(left);

				if (nums[i] < nums[i + 1])
				{
					len[i+1]++;
					left = i;
				}
			}

		}
	}
}

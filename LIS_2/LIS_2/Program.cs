using System;
using System.Linq;
using System.Collections.Generic;

namespace LIS_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			var len = new List<int>();
			var prev = new List<int>();
			var LIS = new List<int>();
			var left = -1;
			LIS.Add(numbers[0]);
			prev.Add(-1);
			len.Add(LIS.Count);
			for (int p = 1; p < numbers.Count; p++)
			{
				if (numbers[p] > numbers[p - 1])
				{
					LIS.Add(numbers[p]);
					len.Add(LIS.Count);
					//za left
					if (len.Count > 1)
					{
						for (int i = len.Count - 1; i >= 0; i--)
						{
							if (len[len.Count - 1] == len[i] + 1)
							{
								left = i;
								prev.Add(left);
								break;
							}
						}
					}

				}
				else if (numbers[p] < numbers[p - 1])
				{
					for (int i = 0; i < LIS.Count - 1; i++)
					{
						if (numbers[p] > LIS[i] && numbers[p] < LIS[i + 1])
						{
							for (int k = LIS.Count-1; k > i; k--)
							{
								LIS.RemoveAt(k);
							}
							LIS.Add(numbers[p]);
							break;

						}
					}
					len.Add(LIS.Count);
					if (len.Count > 1)
					{
						for (int i = len.Count - 1; i >= 0; i--)
						{
							if (len[len.Count - 1] == len[i] + 1)
							{
								left = i;
								prev.Add(left);
								break;
							}
						}
					}
				}

			}
			///////////////////////
			/// 
			/// 
			/// 
			var max = len.Max();
			var stop = -1;
			for (int i = 0; i < len.Count; i++)
			{
				if (max == len[i])
				{
					stop = i;
					break;
				}
			}
			len = new List<int>();
			prev = new List<int>();
			LIS = new List<int>();
			left = -1;
			LIS.Add(numbers[0]);
			prev.Add(-1);
			len.Add(LIS.Count);


			for (int p = 1; p<=stop; p++)
			{
				if (numbers[p] > numbers[p - 1])
				{
					LIS.Add(numbers[p]);
					len.Add(LIS.Count);
					//za left
					if (len.Count > 1)
					{
						for (int i = len.Count - 1; i >= 0; i--)
						{
							if (len[len.Count - 1] == len[i] + 1)
							{
								left = i;
								prev.Add(left);
								break;
							}
						}
					}

				}
				else if (numbers[p] < numbers[p - 1])
				{
					for (int i = 0; i<LIS.Count - 1; i++)
					{
						if (numbers[p] > LIS[i] && numbers[p] < LIS[i + 1])
						{
							for (int k = LIS.Count - 1; k > i; k--)
							{
								LIS.RemoveAt(k);
							}
							LIS.Add(numbers[p]);
							break;

						}
					}
					len.Add(LIS.Count);
					if (len.Count > 1)
					{
						for (int i = len.Count - 1; i >= 0; i--)
						{
							if (len[len.Count - 1] == len[i] + 1)
							{
								left = i;
								prev.Add(left);
								break;
							}
						}
					}
				}

			}






			for (int i = 0; i < LIS.Count; i++)
			{
				Console.Write(LIS[i] + " ");
			}

		}
	}
}

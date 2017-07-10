using System;
using System.Linq;
namespace alpha_string
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var first= Console.ReadLine().Split(' ').ToArray();

			var second = Console.ReadLine().Split(' ').ToArray();


			for (int i = 0; i < Math.Min(first.Length,second.Length)-1; i++)
			{
				var c = string.Compare(first[i], second[i]);
				if (c == -1) 
				{
					Console.WriteLine(string.Join("", first));
					Console.WriteLine(string.Join("", second));
					return;
				}
				if (c == 1)
				{
					Console.WriteLine(string.Join("", second));
					Console.WriteLine(string.Join("", first));
					return;
				}
			}

			if (first.Length > second.Length)
			{
				Console.WriteLine(string.Join("", second));
				Console.WriteLine(string.Join("", first));
			}
			else 
			{
				Console.WriteLine(string.Join("", first));
				Console.WriteLine(string.Join("", second));
			}
			


		}
	}
}

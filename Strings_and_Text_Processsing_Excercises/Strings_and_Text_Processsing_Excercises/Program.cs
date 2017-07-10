using System;
using System.Linq;
using System.Collections.Generic;


			namespace Strings_and_Text_Processsing_Excercises
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine().Split();
			var wantedBase = int.Parse(input[0]);
			var num = input[1];
			var convertetNum = new List<int>();

			while (num>0)
			{
				convertetNum.Add(num % wantedBase);
				num = num / wantedBase;
			}
			convertetNum.Reverse();

			foreach (var Num in convertetNum)
			{
				Console.Write(Num);
			}
		}
	}
}

using System;
using System.Linq;
namespace Max_Count_Gabi1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int count = 1;
int maxcount = 0;
int maxcount1 = 0;
var best = 0;

            for (int num = 0; num<arr.Length - 1; num++)
            {
                for (int num1 = num + 1; num1 <= arr.Length - 1; num1++)
                {
                    if (arr[num] == arr[num1])
                    {
                        count++;
                        maxcount = count;
                    }
                    if (maxcount > maxcount1)
                    {
                        maxcount1 = maxcount;
                        best = num1;
                    }
                    else if (maxcount == maxcount1)
                    {
                        best = num1 - 1 - num;
                    }              
                }
				count = 1;
            }
            Console.WriteLine(arr[best]);


		}
	}
}

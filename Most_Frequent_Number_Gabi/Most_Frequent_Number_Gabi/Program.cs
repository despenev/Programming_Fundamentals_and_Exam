using System;
using System.Linq;
namespace Most_Frequent_Number_Gabi
{
	class MainClass
	{
		public static void Main(string[] args)
		{
var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int count = 1;
int maxcount = 0;
var best = 0;

            for (int i = 0; i<arr.Length; i++)
            {
                for (int j = i + 1; j<arr.Length - 1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        maxcount = count;
                        best = i;

                        
                        if (count > maxcount)
                        {
                            maxcount = count;
                        }
                    }
                   
                }
            }
			Console.WriteLine(maxcount);
            //Console.WriteLine($"{arr[best]}");
            //return;
		}
	}
}

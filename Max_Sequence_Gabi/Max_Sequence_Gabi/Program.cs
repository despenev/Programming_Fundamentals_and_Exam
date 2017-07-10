using System;
using System.Linq;

namespace Max_Sequence_Gabi
{
	class MainClass
	{
		public static void Main(string[] args)
		{

var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
var len = 1;
var start = 0;
var bestLen = 0;
var bestStart = 0;

            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] )
                {
                    len++;
                }

                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
				if (arr[i] <= arr[i - 1])
                {
                    len = 1;
                    start = i;
                }
                
            }
            for (int i = 0; i<bestLen; i++)
            {
                Console.Write(arr[bestStart] + " ");
                bestStart++;
            }
            Console.WriteLine();
		}
	}
}

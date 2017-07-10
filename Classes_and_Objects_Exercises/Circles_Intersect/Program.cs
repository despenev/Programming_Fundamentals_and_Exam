using System;
using System.Collections.Generic;
using System.Linq;

namespace Circles_Intersect
{
	class MainClass
	{

		class Circle
		{
			public Point Center {get ;set;}
			public int Radius {get;set;}
		}
		class Point 
		{
			public int X { get; set; }
			public int Y { get; set; }
		}

		static double CalcDistance(Circle c1, Circle c2)
		{
			var x1 = c1.Center.X;
			var x2 = c2.Center.X;
			var y1 = c1.Center.Y;
			var y2 = c2.Center.Y;

			double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
			return distance;
		}
		public static void Main(string[] args)
		{
			var c1Parameters = Console.ReadLine().Split().Select(int.Parse).ToList();
			var c2Parameters = Console.ReadLine().Split().Select(int.Parse).ToList();

			Point p1 = new Point { X = c1Parameters[0], Y = c1Parameters[1] };
			Point p2 = new Point { X = c2Parameters[0], Y = c2Parameters[1] };

			Circle c1 = new Circle
			{
				Center = p1,
				Radius = c1Parameters[2]
			};
			Circle c2 = new Circle
			{
				Center = p2,
				Radius = c2Parameters[2]
			};

			var distance = CalcDistance(c1, c2);
			if (distance<= c1.Radius+c2.Radius)
				Console.WriteLine("Yes");
			else Console.WriteLine("No");


		}
	}
}

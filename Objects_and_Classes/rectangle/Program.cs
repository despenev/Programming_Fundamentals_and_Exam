using System;

namespace rectangle
{
	class MainClass
	{
		class Rectangle
		{
			public double Top { get; set;}
			public double Left { get; set; }
			public double Width { get; set; }
			public double Height { get; set; }

			public double Bottom
			{
				get { return Top + Height; }
			}

			public double CalcArea()
			{
				return Width * Height;
			}
			public double CalcPerimeter()
			{
				return 2 * (Width + Height);
			}

		}

		public static void Main(string[] args)
		{
			Rectangle firstR = new Rectangle()
			{
				Top = 2,
				Left = 7,
				Width = 5,
				Height = 8
			};

			Console.WriteLine(firstR.CalcArea());
		}
	}
}

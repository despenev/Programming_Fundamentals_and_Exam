using System;

namespace sales
{
	class MainClass
	{
		class Sale
		{
			public string Town { get; set; }
			public string Product { get; set; }
			public decimal Price { get; set; }
			public decimal Quantity{ get; set; }
		}

		class SalesByCity
		{
			public string Town { get; set; }
			public decimal Sales { get; set; }
		}
		public static void Main(string[] args)
		{
			var prodducts = ReadProducts();
			var salesByCiTy = CalcSalesByCity(products);

			foreach (var S in salesByCiTy)
			{

			}
		}
	}
}

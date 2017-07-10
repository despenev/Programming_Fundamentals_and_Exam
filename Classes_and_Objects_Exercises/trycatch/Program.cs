using System;
using System.Collections.Generic;
using System.Linq;

namespace trycatch
{
	class MainClass
	{
		class Customer
		{
			public string Name { get; set; }
			public Dictionary<string, int> Shoplist { get; set; }
			public decimal Bill { get; set; }
		}



		public static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			var Prices = new Dictionary<string, decimal>();
			var CustomersList = new List<Customer>();

			for (int i = 0; i < num; i++)
			{
				var tokens = Console.ReadLine().Split('-').ToList();

				var product = tokens[0];
				var price = decimal.Parse(tokens[1]);

				if (!Prices.ContainsKey(product))
				{
					Prices[product] = 0;
				}
				Prices[product] = price;
			}

			while (true)
			{
				var tokens = Console.ReadLine().Split(new char[] { '-', ',' }).ToList();

				if (tokens[0] == "end of clients")
				{
					foreach (var customer in CustomersList.OrderBy(x => x.Name))
					{
						Console.WriteLine($"{customer.Name}");
						foreach (KeyValuePair<string, int> item in customer.Shoplist)
						{
							Console.WriteLine($"-- {item.Key} - {item.Value}");
						}
						Console.WriteLine($"Bill: {customer.Bill:f2}");
					}
					Console.WriteLine($"Total bill: {CustomersList.Sum(x => x.Bill):f2}");
					return;
				}

				var name = tokens[0];
				var product = tokens[1];
				var quantity = int.Parse(tokens[2]);

				if (Prices.ContainsKey(product))
				{
					if (!CustomersList.Any(x => x.Name == name))
					{
						var customer = new Customer()
						{
							Name = name,
							Shoplist = new Dictionary<string, int> { { $"{product}", quantity } },
							Bill = quantity * Prices[product]
						};

						CustomersList.Add(customer);
					}
					else
					{
						var index = CustomersList.FindIndex(a => a.Name == name);
						CustomersList[index].Bill += quantity * Prices[product];
						try
						{
							CustomersList[index].Shoplist.Add($"{product}", quantity);

						}
						catch (System.ArgumentException) 
						{
							CustomersList[index].Shoplist[product] += quantity;
						}
					}

				}




			}
		}
	}
}

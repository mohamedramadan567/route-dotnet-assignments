using G_NET_23_LINQ02.Models;

namespace G_NET_23_LINQ02.DataSources
{
	public static class Source
	{
		public static List<Product> ProductList = new()
		{
			new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 39 },
			new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.0000M, UnitsInStock = 17 },
			new Product { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.0000M, UnitsInStock = 13 },
			new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22.0000M, UnitsInStock = 53 },
			new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.3500M, UnitsInStock = 0 },
			new Product { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments", UnitPrice = 25.0000M, UnitsInStock = 120 },
			new Product { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce", UnitPrice = 30.0000M, UnitsInStock = 15 },
			new Product { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments", UnitPrice = 40.0000M, UnitsInStock = 6 },
			new Product { ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.0000M, UnitsInStock = 29 },
			new Product { ProductID = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.0000M, UnitsInStock = 31 },
			new Product { ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products", UnitPrice = 21.0000M, UnitsInStock = 22 },
			new Product { ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products", UnitPrice = 38.0000M, UnitsInStock = 86 },
			new Product { ProductID = 13, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.0000M, UnitsInStock = 24 },
			new Product { ProductID = 14, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.2500M, UnitsInStock = 35 },
			new Product { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments", UnitPrice = 15.5000M, UnitsInStock = 39 },
			new Product { ProductID = 16, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.4500M, UnitsInStock = 29 },
			new Product { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39.0000M, UnitsInStock = 0 },
			new Product { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.5000M, UnitsInStock = 42 },
			new Product { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections", UnitPrice = 9.2000M, UnitsInStock = 25 },
			new Product { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections", UnitPrice = 81.0000M, UnitsInStock = 40 },
			new Product { ProductID = 21, ProductName = "Sir Rodney's Scones", Category = "Confections", UnitPrice = 10.0000M, UnitsInStock = 3 },
			new Product { ProductID = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals", UnitPrice = 21.0000M, UnitsInStock = 104 },
			new Product { ProductID = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals", UnitPrice = 9.0000M, UnitsInStock = 61 },
			new Product { ProductID = 24, ProductName = "Guaraná Fantástica", Category = "Beverages", UnitPrice = 4.5000M, UnitsInStock = 20 },
			new Product { ProductID = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections", UnitPrice = 14.0000M, UnitsInStock = 76 },
			new Product { ProductID = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections", UnitPrice = 31.2300M, UnitsInStock = 15 },
			new Product { ProductID = 27, ProductName = "Schoggi Schokolade", Category = "Confections", UnitPrice = 43.9000M, UnitsInStock = 49 },
			new Product { ProductID = 28, ProductName = "Rössle Sauerkraut", Category = "Produce", UnitPrice = 45.6000M, UnitsInStock = 26 },
			new Product { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry", UnitPrice = 123.7900M, UnitsInStock = 0 },
			new Product { ProductID = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood", UnitPrice = 25.8900M, UnitsInStock = 10 },
			new Product { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products", UnitPrice = 12.5000M, UnitsInStock = 0 },
			new Product { ProductID = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products", UnitPrice = 32.0000M, UnitsInStock = 9 },
			new Product { ProductID = 33, ProductName = "Geitost", Category = "Dairy Products", UnitPrice = 2.5000M, UnitsInStock = 112 },
			new Product { ProductID = 34, ProductName = "Sasquatch Ale", Category = "Beverages", UnitPrice = 14.0000M, UnitsInStock = 111 },
			new Product { ProductID = 35, ProductName = "Steeleye Stout", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 20 },
			new Product { ProductID = 36, ProductName = "Inlagd Sill", Category = "Seafood", UnitPrice = 19.0000M, UnitsInStock = 112 },
			new Product { ProductID = 37, ProductName = "Gravad lax", Category = "Seafood", UnitPrice = 26.0000M, UnitsInStock = 11 },
			new Product { ProductID = 38, ProductName = "Côte de Blaye", Category = "Beverages", UnitPrice = 263.5000M, UnitsInStock = 17 },
			new Product { ProductID = 39, ProductName = "Chartreuse verte", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 69 },
			new Product { ProductID = 40, ProductName = "Boston Crab Meat", Category = "Seafood", UnitPrice = 18.4000M, UnitsInStock = 123 },
			new Product { ProductID = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood", UnitPrice = 9.6500M, UnitsInStock = 85 },
			new Product { ProductID = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals", UnitPrice = 14.0000M, UnitsInStock = 26 },
			new Product { ProductID = 43, ProductName = "Ipoh Coffee", Category = "Beverages", UnitPrice = 46.0000M, UnitsInStock = 17 },
			new Product { ProductID = 44, ProductName = "Gula Malacca", Category = "Condiments", UnitPrice = 19.4500M, UnitsInStock = 27 },
			new Product { ProductID = 45, ProductName = "Rogede sild", Category = "Seafood", UnitPrice = 9.5000M, UnitsInStock = 5 },
			new Product { ProductID = 46, ProductName = "Spegesild", Category = "Seafood", UnitPrice = 12.0000M, UnitsInStock = 95 },
			new Product { ProductID = 47, ProductName = "Zaanse koeken", Category = "Confections", UnitPrice = 9.5000M, UnitsInStock = 36 },
			new Product { ProductID = 48, ProductName = "Chocolade", Category = "Confections", UnitPrice = 12.7500M, UnitsInStock = 15 },
			new Product { ProductID = 49, ProductName = "Maxilaku", Category = "Confections", UnitPrice = 20.0000M, UnitsInStock = 10 },
			new Product { ProductID = 50, ProductName = "Valkoinen suklaa", Category = "Confections", UnitPrice = 16.2500M, UnitsInStock = 65 },
			new Product { ProductID = 51, ProductName = "Manjimup Dried Apples", Category = "Produce", UnitPrice = 53.0000M, UnitsInStock = 20 },
			new Product { ProductID = 52, ProductName = "Filo Mix", Category = "Grains/Cereals", UnitPrice = 7.0000M, UnitsInStock = 38 },
			new Product { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry", UnitPrice = 32.8000M, UnitsInStock = 0 },
			new Product { ProductID = 54, ProductName = "Tourtière", Category = "Meat/Poultry", UnitPrice = 7.4500M, UnitsInStock = 21 },
			new Product { ProductID = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry", UnitPrice = 24.0000M, UnitsInStock = 115 },
			new Product { ProductID = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals", UnitPrice = 38.0000M, UnitsInStock = 21 },
			new Product { ProductID = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals", UnitPrice = 19.5000M, UnitsInStock = 36 },
			new Product { ProductID = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood", UnitPrice = 13.2500M, UnitsInStock = 62 },
			new Product { ProductID = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products", UnitPrice = 55.0000M, UnitsInStock = 79 },
			new Product { ProductID = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products", UnitPrice = 34.0000M, UnitsInStock = 19 },
			new Product { ProductID = 61, ProductName = "Sirop d'érable", Category = "Condiments", UnitPrice = 28.5000M, UnitsInStock = 113 },
			new Product { ProductID = 62, ProductName = "Tarte au sucre", Category = "Confections", UnitPrice = 49.3000M, UnitsInStock = 17 },
			new Product { ProductID = 63, ProductName = "Vegie-spread", Category = "Condiments", UnitPrice = 43.9000M, UnitsInStock = 24 },
			new Product { ProductID = 64, ProductName = "Wimmers gute Semmelknödel", Category = "Grains/Cereals", UnitPrice = 33.2500M, UnitsInStock = 22 },
			new Product { ProductID = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments", UnitPrice = 21.0500M, UnitsInStock = 76 },
			new Product { ProductID = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments", UnitPrice = 17.0000M, UnitsInStock = 4 },
			new Product { ProductID = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages", UnitPrice = 14.0000M, UnitsInStock = 52 },
			new Product { ProductID = 68, ProductName = "Scottish Longbreads", Category = "Confections", UnitPrice = 12.5000M, UnitsInStock = 6 },
			new Product { ProductID = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products", UnitPrice = 36.0000M, UnitsInStock = 26 },
			new Product { ProductID = 70, ProductName = "Outback Lager", Category = "Beverages", UnitPrice = 15.0000M, UnitsInStock = 15 },
			new Product { ProductID = 71, ProductName = "Flotemysost", Category = "Dairy Products", UnitPrice = 21.5000M, UnitsInStock = 26 },
			new Product { ProductID = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products", UnitPrice = 34.8000M, UnitsInStock = 14 },
			new Product { ProductID = 73, ProductName = "Röd Kaviar", Category = "Seafood", UnitPrice = 15.0000M, UnitsInStock = 101 },
			new Product { ProductID = 74, ProductName = "Longlife Tofu", Category = "Produce", UnitPrice = 10.0000M, UnitsInStock = 4 },
			new Product { ProductID = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages", UnitPrice = 7.7500M, UnitsInStock = 125 },
			new Product { ProductID = 76, ProductName = "Lakkalikööri", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 57 },
			new Product { ProductID = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments", UnitPrice = 13.0000M, UnitsInStock = 32 }
		};

		public static List<Customer> CustomerList = new()
		{
			new Customer
			{
				CustomerID = "ALFKI",
				CompanyName = "Alfreds Futterkiste",
				Address = "Obere Str. 57",
				City = "Berlin",
				Region = "",
				PostalCode = "12209",
				Country = "Germany",
				Phone = "030-0074321",
				Orders = new Order[]
				{
					new() { OrderID = 10643, OrderDate = new DateTime(1997, 8, 25), Total = 814.50m },
					new() { OrderID = 10692, OrderDate = new DateTime(1997, 10, 3), Total = 878.00m },
					new() { OrderID = 10702, OrderDate = new DateTime(1997, 10, 13), Total = 330.00m },
					new() { OrderID = 10835, OrderDate = new DateTime(1998, 1, 15), Total = 845.80m },
					new() { OrderID = 10952, OrderDate = new DateTime(1998, 3, 16), Total = 471.20m },
					new() { OrderID = 11011, OrderDate = new DateTime(1998, 4, 9), Total = 933.50m },
				}
			},
			new Customer
			{
				CustomerID = "ANATR",
				CompanyName = "Ana Trujillo Emparedados y helados",
				Address = "Avda.de la Constitución 2222",
				City = "México D.F.",
				Region = "",
				PostalCode = "05021",
				Country = "Mexico",
				Phone = "(5) 555-4729",
				Orders = new Order[]
				{
					new() { OrderID = 10308, OrderDate = new DateTime(1996, 9, 18), Total = 88.80m },
					new() { OrderID = 10625, OrderDate = new DateTime(1997, 8, 8), Total = 479.75m },
					new() { OrderID = 10759, OrderDate = new DateTime(1997, 11, 28), Total = 320.00m },
					new() { OrderID = 10926, OrderDate = new DateTime(1998, 3, 4), Total = 514.40m },
				}
			},
			new Customer
			{
				CustomerID = "ANTON",
				CompanyName = "Antonio Moreno Taquería",
				Address = "Mataderos  2312",
				City = "México D.F.",
				Region = "",
				PostalCode = "05023",
				Country = "Mexico",
				Phone = "(5) 555-3932",
				Orders = new Order[]
				{
					new() { OrderID = 10365, OrderDate = new DateTime(1996, 11, 27), Total = 403.20m },
					new() { OrderID = 10507, OrderDate = new DateTime(1997, 4, 15), Total = 749.06m },
					new() { OrderID = 10535, OrderDate = new DateTime(1997, 5, 13), Total = 1940.85m },
					new() { OrderID = 10573, OrderDate = new DateTime(1997, 6, 19), Total = 2082.00m },
					new() { OrderID = 10677, OrderDate = new DateTime(1997, 9, 22), Total = 813.36m },
					new() { OrderID = 10682, OrderDate = new DateTime(1997, 9, 25), Total = 375.50m },
					new() { OrderID = 10856, OrderDate = new DateTime(1998, 1, 28), Total = 660.00m },
				}
			},
			new Customer
			{
				CustomerID = "AROUT",
				CompanyName = "Around the Horn",
				Address = "120 Hanover Sq.",
				City = "London",
				Region = "",
				PostalCode = "WA1 1DP",
				Country = "UK",
				Phone = "(171) 555-7788",
				Orders = new Order[]
				{
					new() { OrderID = 10355, OrderDate = new DateTime(1996, 11, 15), Total = 480.00m },
					new() { OrderID = 10383, OrderDate = new DateTime(1996, 12, 16), Total = 899.00m },
					new() { OrderID = 10453, OrderDate = new DateTime(1997, 2, 21), Total = 407.70m },
					new() { OrderID = 10558, OrderDate = new DateTime(1997, 6, 4), Total = 2142.90m },
					new() { OrderID = 10707, OrderDate = new DateTime(1997, 10, 16), Total = 1641.00m },
					new() { OrderID = 10741, OrderDate = new DateTime(1997, 11, 14), Total = 228.00m },
					new() { OrderID = 10743, OrderDate = new DateTime(1997, 11, 17), Total = 319.20m },
					new() { OrderID = 10768, OrderDate = new DateTime(1997, 12, 8), Total = 1477.00m },
					new() { OrderID = 10793, OrderDate = new DateTime(1997, 12, 24), Total = 191.10m },
					new() { OrderID = 10864, OrderDate = new DateTime(1998, 2, 2), Total = 282.00m },
					new() { OrderID = 10920, OrderDate = new DateTime(1998, 3, 3), Total = 390.00m },
					new() { OrderID = 10953, OrderDate = new DateTime(1998, 3, 16), Total = 4441.25m },
					new() { OrderID = 11016, OrderDate = new DateTime(1998, 4, 10), Total = 491.50m },
				}
			},
			new Customer
			{
				CustomerID = "BERGS",
				CompanyName = "Berglunds snabbköp",
				Address = "Berguvsvägen  8",
				City = "Luleå",
				Region = "",
				PostalCode = "S-958 22",
				Country = "Sweden",
				Phone = "0921-12 34 65",
				Orders = new Order[]
				{
					new() { OrderID = 10278, OrderDate = new DateTime(1996, 8, 12), Total = 1488.80m },
					new() { OrderID = 10280, OrderDate = new DateTime(1996, 8, 14), Total = 613.20m },
					new() { OrderID = 10384, OrderDate = new DateTime(1996, 12, 16), Total = 2222.40m },
					new() { OrderID = 10444, OrderDate = new DateTime(1997, 2, 12), Total = 1031.70m },
					new() { OrderID = 10445, OrderDate = new DateTime(1997, 2, 13), Total = 174.90m },
					new() { OrderID = 10524, OrderDate = new DateTime(1997, 5, 1), Total = 3192.65m },
					new() { OrderID = 10572, OrderDate = new DateTime(1997, 6, 18), Total = 1501.08m },
					new() { OrderID = 10626, OrderDate = new DateTime(1997, 8, 11), Total = 1503.60m },
					new() { OrderID = 10654, OrderDate = new DateTime(1997, 9, 2), Total = 601.83m },
					new() { OrderID = 10672, OrderDate = new DateTime(1997, 9, 17), Total = 3815.25m },
					new() { OrderID = 10689, OrderDate = new DateTime(1997, 10, 1), Total = 472.50m },
					new() { OrderID = 10733, OrderDate = new DateTime(1997, 11, 7), Total = 1459.00m },
					new() { OrderID = 10778, OrderDate = new DateTime(1997, 12, 16), Total = 96.50m },
					new() { OrderID = 10837, OrderDate = new DateTime(1998, 1, 16), Total = 1064.50m },
					new() { OrderID = 10857, OrderDate = new DateTime(1998, 1, 28), Total = 2048.21m },
					new() { OrderID = 10866, OrderDate = new DateTime(1998, 2, 3), Total = 1096.20m },
					new() { OrderID = 10875, OrderDate = new DateTime(1998, 2, 6), Total = 709.55m },
					new() { OrderID = 10924, OrderDate = new DateTime(1998, 3, 4), Total = 1835.70m },
				}
			},
			new Customer
			{
				CustomerID = "BLAUS",
				CompanyName = "Blauer See Delikatessen",
				Address = "Forsterstr. 57",
				City = "Mannheim",
				Region = "",
				PostalCode = "68306",
				Country = "Germany",
				Phone = "0621-08460",
				Orders = new Order[]
				{
					new() { OrderID = 10501, OrderDate = new DateTime(1997, 4, 9), Total = 149.00m },
					new() { OrderID = 10509, OrderDate = new DateTime(1997, 4, 17), Total = 136.80m },
					new() { OrderID = 10582, OrderDate = new DateTime(1997, 6, 27), Total = 330.00m },
					new() { OrderID = 10614, OrderDate = new DateTime(1997, 7, 29), Total = 464.00m },
					new() { OrderID = 10853, OrderDate = new DateTime(1998, 1, 27), Total = 625.00m },
					new() { OrderID = 10956, OrderDate = new DateTime(1998, 3, 17), Total = 677.00m },
					new() { OrderID = 11058, OrderDate = new DateTime(1998, 4, 29), Total = 858.00m },
				}
			},
			new Customer
			{
				CustomerID = "BLONP",
				CompanyName = "Blondel père et fils",
				Address = "24, place Kléber",
				City = "Strasbourg",
				Region = "",
				PostalCode = "67000",
				Country = "France",
				Phone = "88.60.15.31",
				Orders = new Order[]
				{
					new() { OrderID = 10265, OrderDate = new DateTime(1996, 7, 25), Total = 1176.00m },
					new() { OrderID = 10297, OrderDate = new DateTime(1996, 9, 4), Total = 1420.00m },
					new() { OrderID = 10360, OrderDate = new DateTime(1996, 11, 22), Total = 7390.20m },
					new() { OrderID = 10436, OrderDate = new DateTime(1997, 2, 5), Total = 1994.52m },
					new() { OrderID = 10449, OrderDate = new DateTime(1997, 2, 18), Total = 1838.20m },
					new() { OrderID = 10559, OrderDate = new DateTime(1997, 6, 5), Total = 520.41m },
					new() { OrderID = 10566, OrderDate = new DateTime(1997, 6, 12), Total = 1761.00m },
					new() { OrderID = 10584, OrderDate = new DateTime(1997, 6, 30), Total = 593.75m },
					new() { OrderID = 10628, OrderDate = new DateTime(1997, 8, 12), Total = 450.00m },
					new() { OrderID = 10679, OrderDate = new DateTime(1997, 9, 23), Total = 660.00m },
					new() { OrderID = 10826, OrderDate = new DateTime(1998, 1, 12), Total = 730.00m },
				}
			},
			new Customer
			{
				CustomerID = "BOLID",
				CompanyName = "Bólido Comidas preparadas",
				Address = "C/ Araquil, 67",
				City = "Madrid",
				Region = "",
				PostalCode = "28023",
				Country = "Spain",
				Phone = "(91) 555 22 82",
				Orders = new Order[]
				{
					new() { OrderID = 10326, OrderDate = new DateTime(1996, 10, 10), Total = 982.00m },
					new() { OrderID = 10801, OrderDate = new DateTime(1997, 12, 29), Total = 3026.85m },
					new() { OrderID = 10970, OrderDate = new DateTime(1998, 3, 24), Total = 224.00m },
				}
			},
			new Customer
			{
				CustomerID = "BONAP",
				CompanyName = "Bon app'",
				Address = "12, rue des Bouchers",
				City = "Marseille",
				Region = "",
				PostalCode = "13008",
				Country = "France",
				Phone = "91.24.45.40",
				Orders = new Order[]
				{
					new() { OrderID = 10331, OrderDate = new DateTime(1996, 10, 16), Total = 88.50m },
					new() { OrderID = 10340, OrderDate = new DateTime(1996, 10, 29), Total = 2436.18m },
					new() { OrderID = 10362, OrderDate = new DateTime(1996, 11, 25), Total = 1549.60m },
					new() { OrderID = 10470, OrderDate = new DateTime(1997, 3, 11), Total = 1820.80m },
					new() { OrderID = 10511, OrderDate = new DateTime(1997, 4, 18), Total = 2550.00m },
					new() { OrderID = 10525, OrderDate = new DateTime(1997, 5, 2), Total = 818.40m },
					new() { OrderID = 10663, OrderDate = new DateTime(1997, 9, 10), Total = 1930.40m },
					new() { OrderID = 10715, OrderDate = new DateTime(1997, 10, 23), Total = 1296.00m },
					new() { OrderID = 10730, OrderDate = new DateTime(1997, 11, 5), Total = 484.26m },
					new() { OrderID = 10732, OrderDate = new DateTime(1997, 11, 6), Total = 360.00m },
					new() { OrderID = 10755, OrderDate = new DateTime(1997, 11, 26), Total = 1948.50m },
					new() { OrderID = 10827, OrderDate = new DateTime(1998, 1, 12), Total = 843.00m },
					new() { OrderID = 10871, OrderDate = new DateTime(1998, 2, 5), Total = 1979.23m },
					new() { OrderID = 10876, OrderDate = new DateTime(1998, 2, 9), Total = 917.00m },
					new() { OrderID = 10932, OrderDate = new DateTime(1998, 3, 6), Total = 1788.63m },
					new() { OrderID = 10940, OrderDate = new DateTime(1998, 3, 11), Total = 360.00m },
					new() { OrderID = 11076, OrderDate = new DateTime(1998, 5, 6), Total = 792.75m },
				}
			},
			new Customer
			{
				CustomerID = "BOTTM",
				CompanyName = "Bottom-Dollar Markets",
				Address = "23 Tsawassen Blvd.",
				City = "Tsawassen",
				Region = "BC",
				PostalCode = "T2F 8M4",
				Country = "Canada",
				Phone = "(604) 555-4729",
				Orders = new Order[]
				{
					new() { OrderID = 10389, OrderDate = new DateTime(1996, 12, 20), Total = 1832.80m },
					new() { OrderID = 10410, OrderDate = new DateTime(1997, 1, 10), Total = 802.00m },
					new() { OrderID = 10411, OrderDate = new DateTime(1997, 1, 10), Total = 966.80m },
					new() { OrderID = 10431, OrderDate = new DateTime(1997, 1, 30), Total = 1892.25m },
					new() { OrderID = 10492, OrderDate = new DateTime(1997, 4, 1), Total = 851.20m },
					new() { OrderID = 10742, OrderDate = new DateTime(1997, 11, 14), Total = 3118.00m },
					new() { OrderID = 10918, OrderDate = new DateTime(1998, 3, 2), Total = 1447.50m },
					new() { OrderID = 10944, OrderDate = new DateTime(1998, 3, 12), Total = 1025.32m },
					new() { OrderID = 10949, OrderDate = new DateTime(1998, 3, 13), Total = 4422.00m },
					new() { OrderID = 10975, OrderDate = new DateTime(1998, 3, 25), Total = 717.50m },
					new() { OrderID = 10982, OrderDate = new DateTime(1998, 3, 27), Total = 1014.00m },
					new() { OrderID = 11027, OrderDate = new DateTime(1998, 4, 16), Total = 877.72m },
					new() { OrderID = 11045, OrderDate = new DateTime(1998, 4, 23), Total = 1309.50m },
					new() { OrderID = 11048, OrderDate = new DateTime(1998, 4, 24), Total = 525.00m },
				}
			},
			new Customer
			{
				CustomerID = "BSBEV",
				CompanyName = "B's Beverages",
				Address = "Fauntleroy Circus",
				City = "London",
				Region = "",
				PostalCode = "EC2 5NT",
				Country = "UK",
				Phone = "(171) 555-1212",
				Orders = new Order[]
				{
					new() { OrderID = 10289, OrderDate = new DateTime(1996, 8, 26), Total = 479.40m },
					new() { OrderID = 10471, OrderDate = new DateTime(1997, 3, 11), Total = 1328.00m },
					new() { OrderID = 10484, OrderDate = new DateTime(1997, 3, 24), Total = 386.20m },
					new() { OrderID = 10538, OrderDate = new DateTime(1997, 5, 15), Total = 139.80m },
					new() { OrderID = 10539, OrderDate = new DateTime(1997, 5, 16), Total = 355.50m },
					new() { OrderID = 10578, OrderDate = new DateTime(1997, 6, 24), Total = 477.00m },
					new() { OrderID = 10599, OrderDate = new DateTime(1997, 7, 15), Total = 493.00m },
					new() { OrderID = 10943, OrderDate = new DateTime(1998, 3, 11), Total = 711.00m },
					new() { OrderID = 10947, OrderDate = new DateTime(1998, 3, 13), Total = 220.00m },
					new() { OrderID = 11023, OrderDate = new DateTime(1998, 4, 14), Total = 1500.00m },
				}
			},
			new Customer
			{
				CustomerID = "CACTU",
				CompanyName = "Cactus Comidas para llevar",
				Address = "Cerrito 333",
				City = "Buenos Aires",
				Region = "",
				PostalCode = "1010",
				Country = "Argentina",
				Phone = "(1) 135-5555",
				Orders = new Order[]
				{
					new() { OrderID = 10521, OrderDate = new DateTime(1997, 4, 29), Total = 225.50m },
					new() { OrderID = 10782, OrderDate = new DateTime(1997, 12, 17), Total = 12.50m },
					new() { OrderID = 10819, OrderDate = new DateTime(1998, 1, 7), Total = 477.00m },
					new() { OrderID = 10881, OrderDate = new DateTime(1998, 2, 11), Total = 150.00m },
					new() { OrderID = 10937, OrderDate = new DateTime(1998, 3, 10), Total = 644.80m },
					new() { OrderID = 11054, OrderDate = new DateTime(1998, 4, 28), Total = 305.00m },
				}
			},
			new Customer
			{
				CustomerID = "CENTC",
				CompanyName = "Centro comercial Moctezuma",
				Address = "Sierras de Granada 9993",
				City = "México D.F.",
				Region = "",
				PostalCode = "05022",
				Country = "Mexico",
				Phone = "(5) 555-3392",
				Orders = new Order[]
				{
					new() { OrderID = 10259, OrderDate = new DateTime(1996, 7, 18), Total = 100.80m },
				}
			},
			new Customer
			{
				CustomerID = "CHOPS",
				CompanyName = "Chop-suey Chinese",
				Address = "Hauptstr. 29",
				City = "Bern",
				Region = "",
				PostalCode = "3012",
				Country = "Switzerland",
				Phone = "0452-076545",
				Orders = new Order[]
				{
					new() { OrderID = 10254, OrderDate = new DateTime(1996, 7, 11), Total = 556.62m },
					new() { OrderID = 10370, OrderDate = new DateTime(1996, 12, 3), Total = 1117.60m },
					new() { OrderID = 10519, OrderDate = new DateTime(1997, 4, 28), Total = 2314.20m },
					new() { OrderID = 10731, OrderDate = new DateTime(1997, 11, 6), Total = 1890.50m },
					new() { OrderID = 10746, OrderDate = new DateTime(1997, 11, 19), Total = 2311.70m },
					new() { OrderID = 10966, OrderDate = new DateTime(1998, 3, 20), Total = 1098.46m },
					new() { OrderID = 11029, OrderDate = new DateTime(1998, 4, 16), Total = 1286.80m },
					new() { OrderID = 11041, OrderDate = new DateTime(1998, 4, 22), Total = 1773.00m },
				}
			},
			new Customer
			{
				CustomerID = "COMMI",
				CompanyName = "Comércio Mineiro",
				Address = "Av.dos Lusíadas, 23",
				City = "São Paulo",
				Region = "SP",
				PostalCode = "05432-043",
				Country = "Brazil",
				Phone = "(11) 555-7647",
				Orders = new Order[]
				{
					new() { OrderID = 10290, OrderDate = new DateTime(1996, 8, 27), Total = 2169.00m },
					new() { OrderID = 10466, OrderDate = new DateTime(1997, 3, 6), Total = 216.00m },
					new() { OrderID = 10494, OrderDate = new DateTime(1997, 4, 2), Total = 912.00m },
					new() { OrderID = 10969, OrderDate = new DateTime(1998, 3, 23), Total = 108.00m },
					new() { OrderID = 11042, OrderDate = new DateTime(1998, 4, 22), Total = 405.75m },
				}
			},
			new Customer
			{
				CustomerID = "CONSH",
				CompanyName = "Consolidated Holdings",
				Address = "Berkeley Gardens, 12 Brewery",
				City = "London",
				Region = "",
				PostalCode = "WX1 6LT",
				Country = "UK",
				Phone = "(171) 555-2282",
				Orders = new Order[]
				{
					new() { OrderID = 10435, OrderDate = new DateTime(1997, 2, 4), Total = 631.60m },
					new() { OrderID = 10462, OrderDate = new DateTime(1997, 3, 3), Total = 156.00m },
					new() { OrderID = 10848, OrderDate = new DateTime(1998, 1, 23), Total = 931.50m },
				}
			},
			new Customer
			{
				CustomerID = "DRACD",
				CompanyName = "Drachenblut Delikatessen",
				Address = "Walserweg 21",
				City = "Aachen",
				Region = "",
				PostalCode = "52066",
				Country = "Germany",
				Phone = "0241-039123",
				Orders = new Order[]
				{
					new() { OrderID = 10363, OrderDate = new DateTime(1996, 11, 26), Total = 447.20m },
					new() { OrderID = 10391, OrderDate = new DateTime(1996, 12, 23), Total = 86.40m },
					new() { OrderID = 10797, OrderDate = new DateTime(1997, 12, 25), Total = 420.00m },
					new() { OrderID = 10825, OrderDate = new DateTime(1998, 1, 9), Total = 1030.76m },
					new() { OrderID = 11036, OrderDate = new DateTime(1998, 4, 20), Total = 1692.00m },
					new() { OrderID = 11067, OrderDate = new DateTime(1998, 5, 4), Total = 86.85m },
				}
			},
			new Customer
			{
				CustomerID = "DUMON",
				CompanyName = "Du monde entier",
				Address = "67, rue des Cinquante Otages",
				City = "Nantes",
				Region = "",
				PostalCode = "44000",
				Country = "France",
				Phone = "40.67.88.88",
				Orders = new Order[]
				{
					new() { OrderID = 10311, OrderDate = new DateTime(1996, 9, 20), Total = 268.80m },
					new() { OrderID = 10609, OrderDate = new DateTime(1997, 7, 24), Total = 424.00m },
					new() { OrderID = 10683, OrderDate = new DateTime(1997, 9, 26), Total = 63.00m },
					new() { OrderID = 10890, OrderDate = new DateTime(1998, 2, 16), Total = 860.10m },
				}
			},
			new Customer
			{
				CustomerID = "EASTC",
				CompanyName = "Eastern Connection",
				Address = "35 King George",
				City = "London",
				Region = "",
				PostalCode = "WX3 6FW",
				Country = "UK",
				Phone = "(171) 555-0297",
				Orders = new Order[]
				{
					new() { OrderID = 10364, OrderDate = new DateTime(1996, 11, 26), Total = 950.00m },
					new() { OrderID = 10400, OrderDate = new DateTime(1997, 1, 1), Total = 3063.00m },
					new() { OrderID = 10532, OrderDate = new DateTime(1997, 5, 9), Total = 796.35m },
					new() { OrderID = 10726, OrderDate = new DateTime(1997, 11, 3), Total = 655.00m },
					new() { OrderID = 10987, OrderDate = new DateTime(1998, 3, 31), Total = 2772.00m },
					new() { OrderID = 11024, OrderDate = new DateTime(1998, 4, 15), Total = 1966.81m },
					new() { OrderID = 11047, OrderDate = new DateTime(1998, 4, 24), Total = 817.88m },
					new() { OrderID = 11056, OrderDate = new DateTime(1998, 4, 28), Total = 3740.00m },
				}
			},
			new Customer
			{
				CustomerID = "ERNSH",
				CompanyName = "Ernst Handel",
				Address = "Kirchgasse 6",
				City = "Graz",
				Region = "",
				PostalCode = "8010",
				Country = "Austria",
				Phone = "7675-3425",
				Orders = new Order[]
				{
					new() { OrderID = 10258, OrderDate = new DateTime(1996, 7, 17), Total = 1614.88m },
					new() { OrderID = 10263, OrderDate = new DateTime(1996, 7, 23), Total = 1873.80m },
					new() { OrderID = 10351, OrderDate = new DateTime(1996, 11, 11), Total = 5398.72m },
					new() { OrderID = 10368, OrderDate = new DateTime(1996, 11, 29), Total = 1689.78m },
					new() { OrderID = 10382, OrderDate = new DateTime(1996, 12, 13), Total = 2900.00m },
					new() { OrderID = 10390, OrderDate = new DateTime(1996, 12, 23), Total = 2090.88m },
					new() { OrderID = 10402, OrderDate = new DateTime(1997, 1, 2), Total = 2713.50m },
					new() { OrderID = 10403, OrderDate = new DateTime(1997, 1, 3), Total = 855.02m },
					new() { OrderID = 10430, OrderDate = new DateTime(1997, 1, 30), Total = 4899.20m },
					new() { OrderID = 10442, OrderDate = new DateTime(1997, 2, 11), Total = 1792.00m },
					new() { OrderID = 10514, OrderDate = new DateTime(1997, 4, 22), Total = 8623.45m },
					new() { OrderID = 10571, OrderDate = new DateTime(1997, 6, 17), Total = 550.59m },
					new() { OrderID = 10595, OrderDate = new DateTime(1997, 7, 10), Total = 4725.00m },
					new() { OrderID = 10633, OrderDate = new DateTime(1997, 8, 15), Total = 5510.59m },
					new() { OrderID = 10667, OrderDate = new DateTime(1997, 9, 12), Total = 1536.80m },
					new() { OrderID = 10698, OrderDate = new DateTime(1997, 10, 9), Total = 3436.44m },
					new() { OrderID = 10764, OrderDate = new DateTime(1997, 12, 3), Total = 2286.00m },
					new() { OrderID = 10771, OrderDate = new DateTime(1997, 12, 10), Total = 344.00m },
					new() { OrderID = 10773, OrderDate = new DateTime(1997, 12, 11), Total = 2030.40m },
					new() { OrderID = 10776, OrderDate = new DateTime(1997, 12, 15), Total = 6635.28m },
					new() { OrderID = 10795, OrderDate = new DateTime(1997, 12, 24), Total = 2158.00m },
					new() { OrderID = 10836, OrderDate = new DateTime(1998, 1, 16), Total = 4705.50m },
					new() { OrderID = 10854, OrderDate = new DateTime(1998, 1, 27), Total = 2966.50m },
					new() { OrderID = 10895, OrderDate = new DateTime(1998, 2, 18), Total = 6379.40m },
					new() { OrderID = 10968, OrderDate = new DateTime(1998, 3, 23), Total = 1408.00m },
					new() { OrderID = 10979, OrderDate = new DateTime(1998, 3, 26), Total = 4813.50m },
					new() { OrderID = 10990, OrderDate = new DateTime(1998, 4, 1), Total = 4288.85m },
					new() { OrderID = 11008, OrderDate = new DateTime(1998, 4, 8), Total = 4680.90m },
					new() { OrderID = 11017, OrderDate = new DateTime(1998, 4, 13), Total = 6750.00m },
					new() { OrderID = 11072, OrderDate = new DateTime(1998, 5, 5), Total = 5218.00m },
				}
			},
			new Customer
			{
				CustomerID = "FAMIA",
				CompanyName = "Familia Arquibaldo",
				Address = "Rua Orós, 92",
				City = "São Paulo",
				Region = "SP",
				PostalCode = "05442-030",
				Country = "Brazil",
				Phone = "(11) 555-9857",
				Orders = new Order[]
				{
					new() { OrderID = 10347, OrderDate = new DateTime(1996, 11, 6), Total = 814.42m },
					new() { OrderID = 10386, OrderDate = new DateTime(1996, 12, 18), Total = 166.00m },
					new() { OrderID = 10414, OrderDate = new DateTime(1997, 1, 14), Total = 224.83m },
					new() { OrderID = 10512, OrderDate = new DateTime(1997, 4, 21), Total = 525.30m },
					new() { OrderID = 10581, OrderDate = new DateTime(1997, 6, 26), Total = 310.00m },
					new() { OrderID = 10650, OrderDate = new DateTime(1997, 8, 29), Total = 1779.20m },
					new() { OrderID = 10725, OrderDate = new DateTime(1997, 10, 31), Total = 287.80m },
				}
			},
			new Customer
			{
				CustomerID = "FISSA",
				CompanyName = "FISSA Fabrica Inter.Salchichas S.A.",
				Address = "C/ Moralzarzal, 86",
				City = "Madrid",
				Region = "",
				PostalCode = "28034",
				Country = "Spain",
				Phone = "(91) 555 94 44",
				Orders = new Order[]
				{
				}
			},
			new Customer
			{
				CustomerID = "FOLIG",
				CompanyName = "Folies gourmandes",
				Address = "184, chaussée de Tournai",
				City = "Lille",
				Region = "",
				PostalCode = "59000",
				Country = "France",
				Phone = "20.16.10.16",
				Orders = new Order[]
				{
					new() { OrderID = 10408, OrderDate = new DateTime(1997, 1, 8), Total = 1622.40m },
					new() { OrderID = 10480, OrderDate = new DateTime(1997, 3, 20), Total = 756.00m },
					new() { OrderID = 10634, OrderDate = new DateTime(1997, 8, 15), Total = 4985.50m },
					new() { OrderID = 10763, OrderDate = new DateTime(1997, 12, 3), Total = 616.00m },
					new() { OrderID = 10789, OrderDate = new DateTime(1997, 12, 22), Total = 3687.00m },
				}
			},
			new Customer
			{
				CustomerID = "FOLKO",
				CompanyName = "Folk och fä HB",
				Address = "Åkergatan 24",
				City = "Bräcke",
				Region = "",
				PostalCode = "S-844 67",
				Country = "Sweden",
				Phone = "0695-34 67 21",
				Orders = new Order[]
				{
					new() { OrderID = 10264, OrderDate = new DateTime(1996, 7, 24), Total = 695.62m },
					new() { OrderID = 10327, OrderDate = new DateTime(1996, 10, 11), Total = 1810.00m },
					new() { OrderID = 10378, OrderDate = new DateTime(1996, 12, 10), Total = 103.20m },
					new() { OrderID = 10434, OrderDate = new DateTime(1997, 2, 3), Total = 321.12m },
					new() { OrderID = 10460, OrderDate = new DateTime(1997, 2, 28), Total = 176.10m },
					new() { OrderID = 10533, OrderDate = new DateTime(1997, 5, 12), Total = 2222.20m },
					new() { OrderID = 10561, OrderDate = new DateTime(1997, 6, 6), Total = 2844.50m },
					new() { OrderID = 10703, OrderDate = new DateTime(1997, 10, 14), Total = 2545.00m },
					new() { OrderID = 10762, OrderDate = new DateTime(1997, 12, 2), Total = 4337.00m },
					new() { OrderID = 10774, OrderDate = new DateTime(1997, 12, 11), Total = 868.75m },
					new() { OrderID = 10824, OrderDate = new DateTime(1998, 1, 9), Total = 250.80m },
					new() { OrderID = 10880, OrderDate = new DateTime(1998, 2, 10), Total = 1500.00m },
					new() { OrderID = 10902, OrderDate = new DateTime(1998, 2, 23), Total = 863.43m },
					new() { OrderID = 10955, OrderDate = new DateTime(1998, 3, 17), Total = 74.40m },
					new() { OrderID = 10977, OrderDate = new DateTime(1998, 3, 26), Total = 2233.00m },
					new() { OrderID = 10980, OrderDate = new DateTime(1998, 3, 27), Total = 248.00m },
					new() { OrderID = 10993, OrderDate = new DateTime(1998, 4, 1), Total = 4895.44m },
					new() { OrderID = 11001, OrderDate = new DateTime(1998, 4, 6), Total = 2769.00m },
					new() { OrderID = 11050, OrderDate = new DateTime(1998, 4, 27), Total = 810.00m },
				}
			},
			new Customer
			{
				CustomerID = "FRANK",
				CompanyName = "Frankenversand",
				Address = "Berliner Platz 43",
				City = "München",
				Region = "",
				PostalCode = "80805",
				Country = "Germany",
				Phone = "089-0877310",
				Orders = new Order[]
				{
					new() { OrderID = 10267, OrderDate = new DateTime(1996, 7, 29), Total = 3536.60m },
					new() { OrderID = 10337, OrderDate = new DateTime(1996, 10, 24), Total = 2467.00m },
					new() { OrderID = 10342, OrderDate = new DateTime(1996, 10, 30), Total = 1840.64m },
					new() { OrderID = 10396, OrderDate = new DateTime(1996, 12, 27), Total = 1903.80m },
					new() { OrderID = 10488, OrderDate = new DateTime(1997, 3, 27), Total = 1512.00m },
					new() { OrderID = 10560, OrderDate = new DateTime(1997, 6, 6), Total = 1072.42m },
					new() { OrderID = 10623, OrderDate = new DateTime(1997, 8, 7), Total = 1336.95m },
					new() { OrderID = 10653, OrderDate = new DateTime(1997, 9, 2), Total = 1083.15m },
					new() { OrderID = 10670, OrderDate = new DateTime(1997, 9, 16), Total = 2301.75m },
					new() { OrderID = 10675, OrderDate = new DateTime(1997, 9, 19), Total = 1423.00m },
					new() { OrderID = 10717, OrderDate = new DateTime(1997, 10, 24), Total = 1270.75m },
					new() { OrderID = 10791, OrderDate = new DateTime(1997, 12, 23), Total = 1829.76m },
					new() { OrderID = 10859, OrderDate = new DateTime(1998, 1, 29), Total = 1078.69m },
					new() { OrderID = 10929, OrderDate = new DateTime(1998, 3, 5), Total = 1174.75m },
					new() { OrderID = 11012, OrderDate = new DateTime(1998, 4, 9), Total = 2825.30m },
				}
			},
			new Customer
			{
				CustomerID = "FRANR",
				CompanyName = "France restauration",
				Address = "54, rue Royale",
				City = "Nantes",
				Region = "",
				PostalCode = "44000",
				Country = "France",
				Phone = "40.32.21.21",
				Orders = new Order[]
				{
					new() { OrderID = 10671, OrderDate = new DateTime(1997, 9, 17), Total = 920.10m },
					new() { OrderID = 10860, OrderDate = new DateTime(1998, 1, 29), Total = 519.00m },
					new() { OrderID = 10971, OrderDate = new DateTime(1998, 3, 24), Total = 1733.06m },
				}
			},
			new Customer
			{
				CustomerID = "FRANS",
				CompanyName = "Franchi S.p.A.",
				Address = "Via Monte Bianco 34",
				City = "Torino",
				Region = "",
				PostalCode = "10100",
				Country = "Italy",
				Phone = "011-4988260",
				Orders = new Order[]
				{
					new() { OrderID = 10422, OrderDate = new DateTime(1997, 1, 22), Total = 49.80m },
					new() { OrderID = 10710, OrderDate = new DateTime(1997, 10, 20), Total = 93.50m },
					new() { OrderID = 10753, OrderDate = new DateTime(1997, 11, 25), Total = 88.00m },
					new() { OrderID = 10807, OrderDate = new DateTime(1997, 12, 31), Total = 18.40m },
					new() { OrderID = 11026, OrderDate = new DateTime(1998, 4, 15), Total = 1030.00m },
					new() { OrderID = 11060, OrderDate = new DateTime(1998, 4, 30), Total = 266.00m },
				}
			},
			new Customer
			{
				CustomerID = "FURIB",
				CompanyName = "Furia Bacalhau e Frutos do Mar",
				Address = "Jardim das rosas n. 32",
				City = "Lisboa",
				Region = "",
				PostalCode = "1675",
				Country = "Portugal",
				Phone = "(1) 354-2534",
				Orders = new Order[]
				{
					new() { OrderID = 10328, OrderDate = new DateTime(1996, 10, 14), Total = 1168.00m },
					new() { OrderID = 10352, OrderDate = new DateTime(1996, 11, 12), Total = 136.30m },
					new() { OrderID = 10464, OrderDate = new DateTime(1997, 3, 4), Total = 1609.28m },
					new() { OrderID = 10491, OrderDate = new DateTime(1997, 3, 31), Total = 259.50m },
					new() { OrderID = 10551, OrderDate = new DateTime(1997, 5, 28), Total = 1677.30m },
					new() { OrderID = 10604, OrderDate = new DateTime(1997, 7, 18), Total = 230.85m },
					new() { OrderID = 10664, OrderDate = new DateTime(1997, 9, 10), Total = 1288.39m },
					new() { OrderID = 10963, OrderDate = new DateTime(1998, 3, 19), Total = 57.80m },
				}
			},
			new Customer
			{
				CustomerID = "GALED",
				CompanyName = "Galería del gastrónomo",
				Address = "Rambla de Cataluña, 23",
				City = "Barcelona",
				Region = "",
				PostalCode = "08022",
				Country = "Spain",
				Phone = "(93) 203 4560",
				Orders = new Order[]
				{
					new() { OrderID = 10366, OrderDate = new DateTime(1996, 11, 28), Total = 136.00m },
					new() { OrderID = 10426, OrderDate = new DateTime(1997, 1, 27), Total = 338.20m },
					new() { OrderID = 10568, OrderDate = new DateTime(1997, 6, 13), Total = 155.00m },
					new() { OrderID = 10887, OrderDate = new DateTime(1998, 2, 13), Total = 70.00m },
					new() { OrderID = 10928, OrderDate = new DateTime(1998, 3, 5), Total = 137.50m },
				}
			},
			new Customer
			{
				CustomerID = "GODOS",
				CompanyName = "Godos Cocina Típica",
				Address = "C/ Romero, 33",
				City = "Sevilla",
				Region = "",
				PostalCode = "41101",
				Country = "Spain",
				Phone = "(95) 555 82 82",
				Orders = new Order[]
				{
					new() { OrderID = 10303, OrderDate = new DateTime(1996, 9, 11), Total = 1117.80m },
					new() { OrderID = 10550, OrderDate = new DateTime(1997, 5, 28), Total = 683.30m },
					new() { OrderID = 10629, OrderDate = new DateTime(1997, 8, 12), Total = 2775.05m },
					new() { OrderID = 10872, OrderDate = new DateTime(1998, 2, 5), Total = 2058.46m },
					new() { OrderID = 10874, OrderDate = new DateTime(1998, 2, 6), Total = 310.00m },
					new() { OrderID = 10888, OrderDate = new DateTime(1998, 2, 16), Total = 605.00m },
					new() { OrderID = 10911, OrderDate = new DateTime(1998, 2, 26), Total = 858.00m },
					new() { OrderID = 10948, OrderDate = new DateTime(1998, 3, 13), Total = 2362.25m },
					new() { OrderID = 11009, OrderDate = new DateTime(1998, 4, 8), Total = 616.50m },
					new() { OrderID = 11037, OrderDate = new DateTime(1998, 4, 21), Total = 60.00m },
				}
			},
			new Customer
			{
				CustomerID = "GOURL",
				CompanyName = "Gourmet Lanchonetes",
				Address = "Av.Brasil, 442",
				City = "Campinas",
				Region = "SP",
				PostalCode = "04876-786",
				Country = "Brazil",
				Phone = "(11) 555-9482",
				Orders = new Order[]
				{
					new() { OrderID = 10423, OrderDate = new DateTime(1997, 1, 23), Total = 1020.00m },
					new() { OrderID = 10652, OrderDate = new DateTime(1997, 9, 1), Total = 318.84m },
					new() { OrderID = 10685, OrderDate = new DateTime(1997, 9, 29), Total = 801.10m },
					new() { OrderID = 10709, OrderDate = new DateTime(1997, 10, 17), Total = 3424.00m },
					new() { OrderID = 10734, OrderDate = new DateTime(1997, 11, 7), Total = 1498.35m },
					new() { OrderID = 10777, OrderDate = new DateTime(1997, 12, 15), Total = 224.00m },
					new() { OrderID = 10790, OrderDate = new DateTime(1997, 12, 22), Total = 722.50m },
					new() { OrderID = 10959, OrderDate = new DateTime(1998, 3, 18), Total = 131.75m },
					new() { OrderID = 11049, OrderDate = new DateTime(1998, 4, 24), Total = 273.60m },
				}
			},
			new Customer
			{
				CustomerID = "GREAL",
				CompanyName = "Great Lakes Food Market",
				Address = "2732 Baker Blvd.",
				City = "Eugene",
				Region = "OR",
				PostalCode = "97403",
				Country = "USA",
				Phone = "(503) 555-7555",
				Orders = new Order[]
				{
					new() { OrderID = 10528, OrderDate = new DateTime(1997, 5, 6), Total = 392.20m },
					new() { OrderID = 10589, OrderDate = new DateTime(1997, 7, 4), Total = 72.00m },
					new() { OrderID = 10616, OrderDate = new DateTime(1997, 7, 31), Total = 4807.00m },
					new() { OrderID = 10617, OrderDate = new DateTime(1997, 7, 31), Total = 1402.50m },
					new() { OrderID = 10656, OrderDate = new DateTime(1997, 9, 4), Total = 604.22m },
					new() { OrderID = 10681, OrderDate = new DateTime(1997, 9, 25), Total = 1287.40m },
					new() { OrderID = 10816, OrderDate = new DateTime(1998, 1, 6), Total = 8446.45m },
					new() { OrderID = 10936, OrderDate = new DateTime(1998, 3, 9), Total = 456.00m },
					new() { OrderID = 11006, OrderDate = new DateTime(1998, 4, 7), Total = 329.68m },
					new() { OrderID = 11040, OrderDate = new DateTime(1998, 4, 22), Total = 200.00m },
					new() { OrderID = 11061, OrderDate = new DateTime(1998, 4, 30), Total = 510.00m },
				}
			},
			new Customer
			{
				CustomerID = "GROSR",
				CompanyName = "GROSELLA-Restaurante",
				Address = "5ª Ave.Los Palos Grandes",
				City = "Caracas",
				Region = "DF",
				PostalCode = "1081",
				Country = "Venezuela",
				Phone = "(2) 283-2951",
				Orders = new Order[]
				{
					new() { OrderID = 10268, OrderDate = new DateTime(1996, 7, 30), Total = 1101.20m },
					new() { OrderID = 10785, OrderDate = new DateTime(1997, 12, 18), Total = 387.50m },
				}
			},
			new Customer
			{
				CustomerID = "HANAR",
				CompanyName = "Hanari Carnes",
				Address = "Rua do Paço, 67",
				City = "Rio de Janeiro",
				Region = "RJ",
				PostalCode = "05454-876",
				Country = "Brazil",
				Phone = "(21) 555-0091",
				Orders = new Order[]
				{
					new() { OrderID = 10250, OrderDate = new DateTime(1996, 7, 8), Total = 1552.60m },
					new() { OrderID = 10253, OrderDate = new DateTime(1996, 7, 10), Total = 1444.80m },
					new() { OrderID = 10541, OrderDate = new DateTime(1997, 5, 19), Total = 1946.52m },
					new() { OrderID = 10645, OrderDate = new DateTime(1997, 8, 26), Total = 1535.00m },
					new() { OrderID = 10690, OrderDate = new DateTime(1997, 10, 2), Total = 862.50m },
					new() { OrderID = 10770, OrderDate = new DateTime(1997, 12, 9), Total = 236.25m },
					new() { OrderID = 10783, OrderDate = new DateTime(1997, 12, 18), Total = 1442.50m },
					new() { OrderID = 10886, OrderDate = new DateTime(1998, 2, 13), Total = 3127.50m },
					new() { OrderID = 10903, OrderDate = new DateTime(1998, 2, 24), Total = 932.05m },
					new() { OrderID = 10922, OrderDate = new DateTime(1998, 3, 3), Total = 742.50m },
					new() { OrderID = 10925, OrderDate = new DateTime(1998, 3, 4), Total = 475.15m },
					new() { OrderID = 10981, OrderDate = new DateTime(1998, 3, 27), Total = 15810.00m },
					new() { OrderID = 11022, OrderDate = new DateTime(1998, 4, 14), Total = 1402.00m },
					new() { OrderID = 11052, OrderDate = new DateTime(1998, 4, 27), Total = 1332.00m },
				}
			},
			new Customer
			{
				CustomerID = "HILAA",
				CompanyName = "HILARIÓN-Abastos",
				Address = "Carrera 22 con Ave.Carlos Soublette #8-35",
				City = " San Cristóbal",
				Region = "Táchira",
				PostalCode = "5022",
				Country = "Venezuela",
				Phone = "(5) 555-1340",
				Orders = new Order[]
				{
					new() { OrderID = 10257, OrderDate = new DateTime(1996, 7, 16), Total = 1119.90m },
					new() { OrderID = 10395, OrderDate = new DateTime(1996, 12, 26), Total = 2122.92m },
					new() { OrderID = 10476, OrderDate = new DateTime(1997, 3, 17), Total = 180.48m },
					new() { OrderID = 10486, OrderDate = new DateTime(1997, 3, 26), Total = 1272.00m },
					new() { OrderID = 10490, OrderDate = new DateTime(1997, 3, 31), Total = 3163.20m },
					new() { OrderID = 10498, OrderDate = new DateTime(1997, 4, 7), Total = 575.00m },
					new() { OrderID = 10552, OrderDate = new DateTime(1997, 5, 29), Total = 880.50m },
					new() { OrderID = 10601, OrderDate = new DateTime(1997, 7, 16), Total = 2285.00m },
					new() { OrderID = 10613, OrderDate = new DateTime(1997, 7, 29), Total = 353.20m },
					new() { OrderID = 10641, OrderDate = new DateTime(1997, 8, 22), Total = 2054.00m },
					new() { OrderID = 10705, OrderDate = new DateTime(1997, 10, 15), Total = 378.00m },
					new() { OrderID = 10796, OrderDate = new DateTime(1997, 12, 25), Total = 2341.36m },
					new() { OrderID = 10863, OrderDate = new DateTime(1998, 2, 2), Total = 441.15m },
					new() { OrderID = 10901, OrderDate = new DateTime(1998, 2, 23), Total = 934.50m },
					new() { OrderID = 10957, OrderDate = new DateTime(1998, 3, 18), Total = 1762.70m },
					new() { OrderID = 10960, OrderDate = new DateTime(1998, 3, 19), Total = 265.35m },
					new() { OrderID = 10976, OrderDate = new DateTime(1998, 3, 25), Total = 912.00m },
					new() { OrderID = 11055, OrderDate = new DateTime(1998, 4, 28), Total = 1727.50m },
				}
			},
			new Customer
			{
				CustomerID = "HUNGC",
				CompanyName = "Hungry Coyote Import Store",
				Address = "City Center Plaza, 516 Main St.",
				City = "Elgin",
				Region = "OR",
				PostalCode = "97827",
				Country = "USA",
				Phone = "(503) 555-6874",
				Orders = new Order[]
				{
					new() { OrderID = 10375, OrderDate = new DateTime(1996, 12, 6), Total = 338.00m },
					new() { OrderID = 10394, OrderDate = new DateTime(1996, 12, 25), Total = 442.00m },
					new() { OrderID = 10415, OrderDate = new DateTime(1997, 1, 15), Total = 102.40m },
					new() { OrderID = 10600, OrderDate = new DateTime(1997, 7, 16), Total = 479.80m },
					new() { OrderID = 10660, OrderDate = new DateTime(1997, 9, 8), Total = 1701.00m },
				}
			},
			new Customer
			{
				CustomerID = "HUNGO",
				CompanyName = "Hungry Owl All-Night Grocers",
				Address = "8 Johnstown Road",
				City = "Cork",
				Region = "Co.Cork",
				PostalCode = "",
				Country = "Ireland",
				Phone = "2967 542",
				Orders = new Order[]
				{
					new() { OrderID = 10298, OrderDate = new DateTime(1996, 9, 5), Total = 2645.00m },
					new() { OrderID = 10309, OrderDate = new DateTime(1996, 9, 19), Total = 1762.00m },
					new() { OrderID = 10335, OrderDate = new DateTime(1996, 10, 22), Total = 2036.16m },
					new() { OrderID = 10373, OrderDate = new DateTime(1996, 12, 5), Total = 1366.40m },
					new() { OrderID = 10380, OrderDate = new DateTime(1996, 12, 12), Total = 1313.82m },
					new() { OrderID = 10429, OrderDate = new DateTime(1997, 1, 29), Total = 1441.38m },
					new() { OrderID = 10503, OrderDate = new DateTime(1997, 4, 11), Total = 2048.50m },
					new() { OrderID = 10516, OrderDate = new DateTime(1997, 4, 24), Total = 2381.05m },
					new() { OrderID = 10567, OrderDate = new DateTime(1997, 6, 12), Total = 2519.00m },
					new() { OrderID = 10646, OrderDate = new DateTime(1997, 8, 27), Total = 1446.00m },
					new() { OrderID = 10661, OrderDate = new DateTime(1997, 9, 9), Total = 562.60m },
					new() { OrderID = 10687, OrderDate = new DateTime(1997, 9, 30), Total = 4960.90m },
					new() { OrderID = 10701, OrderDate = new DateTime(1997, 10, 13), Total = 2864.50m },
					new() { OrderID = 10712, OrderDate = new DateTime(1997, 10, 21), Total = 1233.48m },
					new() { OrderID = 10736, OrderDate = new DateTime(1997, 11, 11), Total = 997.00m },
					new() { OrderID = 10897, OrderDate = new DateTime(1998, 2, 19), Total = 10835.24m },
					new() { OrderID = 10912, OrderDate = new DateTime(1998, 2, 26), Total = 6200.55m },
					new() { OrderID = 10985, OrderDate = new DateTime(1998, 3, 30), Total = 2023.38m },
					new() { OrderID = 11063, OrderDate = new DateTime(1998, 4, 30), Total = 1342.95m },
				}
			},
			new Customer
			{
				CustomerID = "ISLAT",
				CompanyName = "Island Trading",
				Address = "Garden House, Crowther Way",
				City = "Cowes",
				Region = "Isle of Wight",
				PostalCode = "PO31 7PJ",
				Country = "UK",
				Phone = "(198) 555-8888",
				Orders = new Order[]
				{
					new() { OrderID = 10315, OrderDate = new DateTime(1996, 9, 26), Total = 516.80m },
					new() { OrderID = 10318, OrderDate = new DateTime(1996, 10, 1), Total = 240.40m },
					new() { OrderID = 10321, OrderDate = new DateTime(1996, 10, 3), Total = 144.00m },
					new() { OrderID = 10473, OrderDate = new DateTime(1997, 3, 13), Total = 230.40m },
					new() { OrderID = 10621, OrderDate = new DateTime(1997, 8, 5), Total = 758.50m },
					new() { OrderID = 10674, OrderDate = new DateTime(1997, 9, 18), Total = 45.00m },
					new() { OrderID = 10749, OrderDate = new DateTime(1997, 11, 20), Total = 1080.00m },
					new() { OrderID = 10798, OrderDate = new DateTime(1997, 12, 26), Total = 446.60m },
					new() { OrderID = 10829, OrderDate = new DateTime(1998, 1, 13), Total = 1764.00m },
					new() { OrderID = 10933, OrderDate = new DateTime(1998, 3, 6), Total = 920.60m },
				}
			},
			new Customer
			{
				CustomerID = "KOENE",
				CompanyName = "Königlich Essen",
				Address = "Maubelstr. 90",
				City = "Brandenburg",
				Region = "",
				PostalCode = "14776",
				Country = "Germany",
				Phone = "0555-09876",
				Orders = new Order[]
				{
					new() { OrderID = 10323, OrderDate = new DateTime(1996, 10, 7), Total = 164.40m },
					new() { OrderID = 10325, OrderDate = new DateTime(1996, 10, 9), Total = 1497.00m },
					new() { OrderID = 10456, OrderDate = new DateTime(1997, 2, 25), Total = 557.60m },
					new() { OrderID = 10457, OrderDate = new DateTime(1997, 2, 25), Total = 1584.00m },
					new() { OrderID = 10468, OrderDate = new DateTime(1997, 3, 7), Total = 717.60m },
					new() { OrderID = 10506, OrderDate = new DateTime(1997, 4, 15), Total = 415.80m },
					new() { OrderID = 10542, OrderDate = new DateTime(1997, 5, 20), Total = 469.11m },
					new() { OrderID = 10630, OrderDate = new DateTime(1997, 8, 13), Total = 903.60m },
					new() { OrderID = 10718, OrderDate = new DateTime(1997, 10, 27), Total = 3463.00m },
					new() { OrderID = 10799, OrderDate = new DateTime(1997, 12, 26), Total = 1553.50m },
					new() { OrderID = 10817, OrderDate = new DateTime(1998, 1, 6), Total = 10952.84m },
					new() { OrderID = 10849, OrderDate = new DateTime(1998, 1, 23), Total = 967.82m },
					new() { OrderID = 10893, OrderDate = new DateTime(1998, 2, 18), Total = 5502.11m },
					new() { OrderID = 11028, OrderDate = new DateTime(1998, 4, 16), Total = 2160.00m },
				}
			},
			new Customer
			{
				CustomerID = "LACOR",
				CompanyName = "La corne d'abondance",
				Address = "67, avenue de l'Europe",
				City = "Versailles",
				Region = "",
				PostalCode = "78000",
				Country = "France",
				Phone = "30.59.84.10",
				Orders = new Order[]
				{
					new() { OrderID = 10858, OrderDate = new DateTime(1998, 1, 29), Total = 649.00m },
					new() { OrderID = 10927, OrderDate = new DateTime(1998, 3, 5), Total = 800.00m },
					new() { OrderID = 10972, OrderDate = new DateTime(1998, 3, 24), Total = 251.50m },
					new() { OrderID = 10973, OrderDate = new DateTime(1998, 3, 24), Total = 291.55m },
				}
			},
			new Customer
			{
				CustomerID = "LAMAI",
				CompanyName = "La maison d'Asie",
				Address = "1 rue Alsace-Lorraine",
				City = "Toulouse",
				Region = "",
				PostalCode = "31000",
				Country = "France",
				Phone = "61.77.61.10",
				Orders = new Order[]
				{
					new() { OrderID = 10350, OrderDate = new DateTime(1996, 11, 11), Total = 642.06m },
					new() { OrderID = 10358, OrderDate = new DateTime(1996, 11, 20), Total = 429.40m },
					new() { OrderID = 10371, OrderDate = new DateTime(1996, 12, 3), Total = 72.96m },
					new() { OrderID = 10413, OrderDate = new DateTime(1997, 1, 14), Total = 2123.20m },
					new() { OrderID = 10425, OrderDate = new DateTime(1997, 1, 24), Total = 360.00m },
					new() { OrderID = 10454, OrderDate = new DateTime(1997, 2, 21), Total = 331.20m },
					new() { OrderID = 10493, OrderDate = new DateTime(1997, 4, 2), Total = 608.40m },
					new() { OrderID = 10500, OrderDate = new DateTime(1997, 4, 9), Total = 523.26m },
					new() { OrderID = 10610, OrderDate = new DateTime(1997, 7, 25), Total = 299.25m },
					new() { OrderID = 10631, OrderDate = new DateTime(1997, 8, 14), Total = 55.80m },
					new() { OrderID = 10787, OrderDate = new DateTime(1997, 12, 19), Total = 2622.76m },
					new() { OrderID = 10832, OrderDate = new DateTime(1998, 1, 14), Total = 475.11m },
					new() { OrderID = 10923, OrderDate = new DateTime(1998, 3, 3), Total = 748.80m },
					new() { OrderID = 11051, OrderDate = new DateTime(1998, 4, 27), Total = 36.00m },
				}
			},
			new Customer
			{
				CustomerID = "LAUGB",
				CompanyName = "Laughing Bacchus Wine Cellars",
				Address = "1900 Oak St.",
				City = "Vancouver",
				Region = "BC",
				PostalCode = "V3F 2K1",
				Country = "Canada",
				Phone = "(604) 555-3392",
				Orders = new Order[]
				{
					new() { OrderID = 10495, OrderDate = new DateTime(1997, 4, 3), Total = 278.00m },
					new() { OrderID = 10620, OrderDate = new DateTime(1997, 8, 5), Total = 57.50m },
					new() { OrderID = 10810, OrderDate = new DateTime(1998, 1, 1), Total = 187.00m },
				}
			},
			new Customer
			{
				CustomerID = "LAZYK",
				CompanyName = "Lazy K Kountry Store",
				Address = "12 Orchestra Terrace",
				City = "Walla Walla",
				Region = "WA",
				PostalCode = "99362",
				Country = "USA",
				Phone = "(509) 555-7969",
				Orders = new Order[]
				{
					new() { OrderID = 10482, OrderDate = new DateTime(1997, 3, 21), Total = 147.00m },
					new() { OrderID = 10545, OrderDate = new DateTime(1997, 5, 22), Total = 210.00m },
				}
			},
			new Customer
			{
				CustomerID = "LEHMS",
				CompanyName = "Lehmanns Marktstand",
				Address = "Magazinweg 7",
				City = "Frankfurt a.M. ",
				Region = "",
				PostalCode = "60528",
				Country = "Germany",
				Phone = "069-0245984",
				Orders = new Order[]
				{
					new() { OrderID = 10279, OrderDate = new DateTime(1996, 8, 13), Total = 351.00m },
					new() { OrderID = 10284, OrderDate = new DateTime(1996, 8, 19), Total = 1170.38m },
					new() { OrderID = 10343, OrderDate = new DateTime(1996, 10, 31), Total = 1584.00m },
					new() { OrderID = 10497, OrderDate = new DateTime(1997, 4, 4), Total = 1380.60m },
					new() { OrderID = 10522, OrderDate = new DateTime(1997, 4, 30), Total = 2318.24m },
					new() { OrderID = 10534, OrderDate = new DateTime(1997, 5, 12), Total = 465.70m },
					new() { OrderID = 10536, OrderDate = new DateTime(1997, 5, 14), Total = 1645.00m },
					new() { OrderID = 10557, OrderDate = new DateTime(1997, 6, 3), Total = 1152.50m },
					new() { OrderID = 10592, OrderDate = new DateTime(1997, 7, 8), Total = 516.47m },
					new() { OrderID = 10593, OrderDate = new DateTime(1997, 7, 9), Total = 1994.40m },
					new() { OrderID = 10772, OrderDate = new DateTime(1997, 12, 10), Total = 3603.22m },
					new() { OrderID = 10862, OrderDate = new DateTime(1998, 1, 30), Total = 581.00m },
					new() { OrderID = 10891, OrderDate = new DateTime(1998, 2, 17), Total = 368.93m },
					new() { OrderID = 10934, OrderDate = new DateTime(1998, 3, 9), Total = 500.00m },
					new() { OrderID = 11070, OrderDate = new DateTime(1998, 5, 5), Total = 1629.98m },
				}
			},
			new Customer
			{
				CustomerID = "LETSS",
				CompanyName = "Let's Stop N Shop",
				Address = "87 Polk St. Suite 5",
				City = "San Francisco",
				Region = "CA",
				PostalCode = "94117",
				Country = "USA",
				Phone = "(415) 555-5938",
				Orders = new Order[]
				{
					new() { OrderID = 10579, OrderDate = new DateTime(1997, 6, 25), Total = 317.75m },
					new() { OrderID = 10719, OrderDate = new DateTime(1997, 10, 27), Total = 844.25m },
					new() { OrderID = 10735, OrderDate = new DateTime(1997, 11, 10), Total = 536.40m },
					new() { OrderID = 10884, OrderDate = new DateTime(1998, 2, 12), Total = 1378.07m },
				}
			},
			new Customer
			{
				CustomerID = "LILAS",
				CompanyName = "LILA-Supermercado",
				Address = "Carrera 52 con Ave.Bolívar #65-98 Llano Largo",
				City = "Barquisimeto",
				Region = "Lara",
				PostalCode = "3508",
				Country = "Venezuela",
				Phone = "(9) 331-6954",
				Orders = new Order[]
				{
					new() { OrderID = 10283, OrderDate = new DateTime(1996, 8, 16), Total = 1414.80m },
					new() { OrderID = 10296, OrderDate = new DateTime(1996, 9, 3), Total = 1050.60m },
					new() { OrderID = 10330, OrderDate = new DateTime(1996, 10, 16), Total = 1649.00m },
					new() { OrderID = 10357, OrderDate = new DateTime(1996, 11, 19), Total = 1167.68m },
					new() { OrderID = 10381, OrderDate = new DateTime(1996, 12, 12), Total = 112.00m },
					new() { OrderID = 10461, OrderDate = new DateTime(1997, 2, 28), Total = 1538.70m },
					new() { OrderID = 10499, OrderDate = new DateTime(1997, 4, 8), Total = 1412.00m },
					new() { OrderID = 10543, OrderDate = new DateTime(1997, 5, 21), Total = 1504.50m },
					new() { OrderID = 10780, OrderDate = new DateTime(1997, 12, 16), Total = 720.00m },
					new() { OrderID = 10823, OrderDate = new DateTime(1998, 1, 9), Total = 2826.00m },
					new() { OrderID = 10899, OrderDate = new DateTime(1998, 2, 20), Total = 122.40m },
					new() { OrderID = 10997, OrderDate = new DateTime(1998, 4, 3), Total = 1885.00m },
					new() { OrderID = 11065, OrderDate = new DateTime(1998, 5, 1), Total = 189.42m },
					new() { OrderID = 11071, OrderDate = new DateTime(1998, 5, 5), Total = 484.50m },
				}
			},
			new Customer
			{
				CustomerID = "LINOD",
				CompanyName = "LINO-Delicateses",
				Address = "Ave. 5 de Mayo Porlamar",
				City = "I.de Margarita",
				Region = "Nueva Esparta",
				PostalCode = "4980",
				Country = "Venezuela",
				Phone = "(8) 34-56-12",
				Orders = new Order[]
				{
					new() { OrderID = 10405, OrderDate = new DateTime(1997, 1, 6), Total = 400.00m },
					new() { OrderID = 10485, OrderDate = new DateTime(1997, 3, 25), Total = 1584.00m },
					new() { OrderID = 10638, OrderDate = new DateTime(1997, 8, 20), Total = 2720.05m },
					new() { OrderID = 10697, OrderDate = new DateTime(1997, 10, 8), Total = 805.42m },
					new() { OrderID = 10729, OrderDate = new DateTime(1997, 11, 4), Total = 1850.00m },
					new() { OrderID = 10811, OrderDate = new DateTime(1998, 1, 2), Total = 852.00m },
					new() { OrderID = 10838, OrderDate = new DateTime(1998, 1, 19), Total = 1938.38m },
					new() { OrderID = 10840, OrderDate = new DateTime(1998, 1, 19), Total = 211.20m },
					new() { OrderID = 10919, OrderDate = new DateTime(1998, 3, 2), Total = 1122.80m },
					new() { OrderID = 10954, OrderDate = new DateTime(1998, 3, 17), Total = 1659.54m },
					new() { OrderID = 11014, OrderDate = new DateTime(1998, 4, 10), Total = 243.18m },
					new() { OrderID = 11039, OrderDate = new DateTime(1998, 4, 21), Total = 3090.00m },
				}
			},
			new Customer
			{
				CustomerID = "LONEP",
				CompanyName = "Lonesome Pine Restaurant",
				Address = "89 Chiaroscuro Rd.",
				City = "Portland",
				Region = "OR",
				PostalCode = "97219",
				Country = "USA",
				Phone = "(503) 555-9573",
				Orders = new Order[]
				{
					new() { OrderID = 10307, OrderDate = new DateTime(1996, 9, 17), Total = 424.00m },
					new() { OrderID = 10317, OrderDate = new DateTime(1996, 9, 30), Total = 288.00m },
					new() { OrderID = 10544, OrderDate = new DateTime(1997, 5, 21), Total = 417.20m },
					new() { OrderID = 10662, OrderDate = new DateTime(1997, 9, 9), Total = 125.00m },
					new() { OrderID = 10665, OrderDate = new DateTime(1997, 9, 11), Total = 1295.00m },
					new() { OrderID = 10867, OrderDate = new DateTime(1998, 2, 3), Total = 98.40m },
					new() { OrderID = 10883, OrderDate = new DateTime(1998, 2, 12), Total = 36.00m },
					new() { OrderID = 11018, OrderDate = new DateTime(1998, 4, 13), Total = 1575.00m },
				}
			},
			new Customer
			{
				CustomerID = "MAGAA",
				CompanyName = "Magazzini Alimentari Riuniti",
				Address = "Via Ludovico il Moro 22",
				City = "Bergamo",
				Region = "",
				PostalCode = "24100",
				Country = "Italy",
				Phone = "035-640230",
				Orders = new Order[]
				{
					new() { OrderID = 10275, OrderDate = new DateTime(1996, 8, 7), Total = 291.84m },
					new() { OrderID = 10300, OrderDate = new DateTime(1996, 9, 9), Total = 608.00m },
					new() { OrderID = 10404, OrderDate = new DateTime(1997, 1, 3), Total = 1591.25m },
					new() { OrderID = 10467, OrderDate = new DateTime(1997, 3, 6), Total = 235.20m },
					new() { OrderID = 10635, OrderDate = new DateTime(1997, 8, 18), Total = 1326.22m },
					new() { OrderID = 10754, OrderDate = new DateTime(1997, 11, 25), Total = 55.20m },
					new() { OrderID = 10784, OrderDate = new DateTime(1997, 12, 18), Total = 1488.00m },
					new() { OrderID = 10818, OrderDate = new DateTime(1998, 1, 7), Total = 833.00m },
					new() { OrderID = 10939, OrderDate = new DateTime(1998, 3, 10), Total = 637.50m },
					new() { OrderID = 10950, OrderDate = new DateTime(1998, 3, 16), Total = 110.00m },
				}
			},
			new Customer
			{
				CustomerID = "MAISD",
				CompanyName = "Maison Dewey",
				Address = "Rue Joseph-Bens 532",
				City = "Bruxelles",
				Region = "",
				PostalCode = "B-1180",
				Country = "Belgium",
				Phone = "(02) 201 24 67",
				Orders = new Order[]
				{
					new() { OrderID = 10529, OrderDate = new DateTime(1997, 5, 7), Total = 946.00m },
					new() { OrderID = 10649, OrderDate = new DateTime(1997, 8, 28), Total = 1434.00m },
					new() { OrderID = 10760, OrderDate = new DateTime(1997, 12, 1), Total = 2917.00m },
					new() { OrderID = 10892, OrderDate = new DateTime(1998, 2, 17), Total = 2090.00m },
					new() { OrderID = 10896, OrderDate = new DateTime(1998, 2, 19), Total = 750.50m },
					new() { OrderID = 10978, OrderDate = new DateTime(1998, 3, 26), Total = 1303.20m },
					new() { OrderID = 11004, OrderDate = new DateTime(1998, 4, 7), Total = 295.38m },
				}
			},
			new Customer
			{
				CustomerID = "MEREP",
				CompanyName = "Mère Paillarde",
				Address = "43 rue St. Laurent",
				City = "Montréal",
				Region = "Québec",
				PostalCode = "H1J 1C3",
				Country = "Canada",
				Phone = "(514) 555-8054",
				Orders = new Order[]
				{
					new() { OrderID = 10332, OrderDate = new DateTime(1996, 10, 17), Total = 1786.88m },
					new() { OrderID = 10339, OrderDate = new DateTime(1996, 10, 28), Total = 3354.00m },
					new() { OrderID = 10376, OrderDate = new DateTime(1996, 12, 9), Total = 399.00m },
					new() { OrderID = 10424, OrderDate = new DateTime(1997, 1, 23), Total = 9194.56m },
					new() { OrderID = 10439, OrderDate = new DateTime(1997, 2, 7), Total = 1078.00m },
					new() { OrderID = 10505, OrderDate = new DateTime(1997, 4, 14), Total = 147.90m },
					new() { OrderID = 10565, OrderDate = new DateTime(1997, 6, 11), Total = 639.90m },
					new() { OrderID = 10570, OrderDate = new DateTime(1997, 6, 17), Total = 2465.25m },
					new() { OrderID = 10590, OrderDate = new DateTime(1997, 7, 7), Total = 1101.00m },
					new() { OrderID = 10605, OrderDate = new DateTime(1997, 7, 21), Total = 4109.70m },
					new() { OrderID = 10618, OrderDate = new DateTime(1997, 8, 1), Total = 2697.50m },
					new() { OrderID = 10619, OrderDate = new DateTime(1997, 8, 4), Total = 1260.00m },
					new() { OrderID = 10724, OrderDate = new DateTime(1997, 10, 30), Total = 638.50m },
				}
			},
			new Customer
			{
				CustomerID = "MORGK",
				CompanyName = "Morgenstern Gesundkost",
				Address = "Heerstr. 22",
				City = "Leipzig",
				Region = "",
				PostalCode = "04179",
				Country = "Germany",
				Phone = "0342-023176",
				Orders = new Order[]
				{
					new() { OrderID = 10277, OrderDate = new DateTime(1996, 8, 9), Total = 1200.80m },
					new() { OrderID = 10575, OrderDate = new DateTime(1997, 6, 20), Total = 2147.40m },
					new() { OrderID = 10699, OrderDate = new DateTime(1997, 10, 9), Total = 114.00m },
					new() { OrderID = 10779, OrderDate = new DateTime(1997, 12, 16), Total = 1335.00m },
					new() { OrderID = 10945, OrderDate = new DateTime(1998, 3, 12), Total = 245.00m },
				}
			},
			new Customer
			{
				CustomerID = "NORTS",
				CompanyName = "North/South",
				Address = "South House, 300 Queensbridge",
				City = "London",
				Region = "",
				PostalCode = "SW7 1RZ",
				Country = "UK",
				Phone = "(171) 555-7733",
				Orders = new Order[]
				{
					new() { OrderID = 10517, OrderDate = new DateTime(1997, 4, 24), Total = 352.00m },
					new() { OrderID = 10752, OrderDate = new DateTime(1997, 11, 24), Total = 252.00m },
					new() { OrderID = 11057, OrderDate = new DateTime(1998, 4, 29), Total = 45.00m },
				}
			},
			new Customer
			{
				CustomerID = "OCEAN",
				CompanyName = "Océano Atlántico Ltda.",
				Address = "Ing.Gustavo Moncada 8585, Piso 20-A",
				City = "Buenos Aires",
				Region = "",
				PostalCode = "1010",
				Country = "Argentina",
				Phone = "(1) 135-5333",
				Orders = new Order[]
				{
					new() { OrderID = 10409, OrderDate = new DateTime(1997, 1, 9), Total = 319.20m },
					new() { OrderID = 10531, OrderDate = new DateTime(1997, 5, 8), Total = 110.00m },
					new() { OrderID = 10898, OrderDate = new DateTime(1998, 2, 20), Total = 30.00m },
					new() { OrderID = 10958, OrderDate = new DateTime(1998, 3, 18), Total = 781.00m },
					new() { OrderID = 10986, OrderDate = new DateTime(1998, 3, 30), Total = 2220.00m },
				}
			},
			new Customer
			{
				CustomerID = "OLDWO",
				CompanyName = "Old World Delicatessen",
				Address = "2743 Bering St.",
				City = "Anchorage",
				Region = "AK",
				PostalCode = "99508",
				Country = "USA",
				Phone = "(907) 555-7584",
				Orders = new Order[]
				{
					new() { OrderID = 10260, OrderDate = new DateTime(1996, 7, 19), Total = 1504.65m },
					new() { OrderID = 10305, OrderDate = new DateTime(1996, 9, 13), Total = 3741.30m },
					new() { OrderID = 10338, OrderDate = new DateTime(1996, 10, 25), Total = 934.50m },
					new() { OrderID = 10441, OrderDate = new DateTime(1997, 2, 10), Total = 1755.00m },
					new() { OrderID = 10594, OrderDate = new DateTime(1997, 7, 9), Total = 565.50m },
					new() { OrderID = 10680, OrderDate = new DateTime(1997, 9, 24), Total = 1261.88m },
					new() { OrderID = 10706, OrderDate = new DateTime(1997, 10, 16), Total = 1893.00m },
					new() { OrderID = 10855, OrderDate = new DateTime(1998, 1, 27), Total = 2227.89m },
					new() { OrderID = 10965, OrderDate = new DateTime(1998, 3, 20), Total = 848.00m },
					new() { OrderID = 11034, OrderDate = new DateTime(1998, 4, 20), Total = 539.40m },
				}
			},
			new Customer
			{
				CustomerID = "OTTIK",
				CompanyName = "Ottilies Käseladen",
				Address = "Mehrheimerstr. 369",
				City = "Köln",
				Region = "",
				PostalCode = "50739",
				Country = "Germany",
				Phone = "0221-0644327",
				Orders = new Order[]
				{
					new() { OrderID = 10407, OrderDate = new DateTime(1997, 1, 7), Total = 1194.00m },
					new() { OrderID = 10508, OrderDate = new DateTime(1997, 4, 16), Total = 240.00m },
					new() { OrderID = 10554, OrderDate = new DateTime(1997, 5, 30), Total = 1728.52m },
					new() { OrderID = 10580, OrderDate = new DateTime(1997, 6, 26), Total = 1013.74m },
					new() { OrderID = 10684, OrderDate = new DateTime(1997, 9, 26), Total = 1768.00m },
					new() { OrderID = 10766, OrderDate = new DateTime(1997, 12, 5), Total = 2310.00m },
					new() { OrderID = 10833, OrderDate = new DateTime(1998, 1, 15), Total = 906.93m },
					new() { OrderID = 10999, OrderDate = new DateTime(1998, 4, 3), Total = 1197.95m },
					new() { OrderID = 11020, OrderDate = new DateTime(1998, 4, 14), Total = 632.40m },
				}
			},
			new Customer
			{
				CustomerID = "PARIS",
				CompanyName = "Paris spécialités",
				Address = "265, boulevard Charonne",
				City = "Paris",
				Region = "",
				PostalCode = "75012",
				Country = "France",
				Phone = "(1) 42.34.22.66",
				Orders = new Order[]
				{
				}
			},
			new Customer
			{
				CustomerID = "PERIC",
				CompanyName = "Pericles Comidas clásicas",
				Address = "Calle Dr.Jorge Cash 321",
				City = "México D.F.",
				Region = "",
				PostalCode = "05033",
				Country = "Mexico",
				Phone = "(5) 552-3745",
				Orders = new Order[]
				{
					new() { OrderID = 10322, OrderDate = new DateTime(1996, 10, 4), Total = 112.00m },
					new() { OrderID = 10354, OrderDate = new DateTime(1996, 11, 14), Total = 568.80m },
					new() { OrderID = 10474, OrderDate = new DateTime(1997, 3, 13), Total = 1249.10m },
					new() { OrderID = 10502, OrderDate = new DateTime(1997, 4, 10), Total = 816.30m },
					new() { OrderID = 10995, OrderDate = new DateTime(1998, 4, 2), Total = 1196.00m },
					new() { OrderID = 11073, OrderDate = new DateTime(1998, 5, 5), Total = 300.00m },
				}
			},
			new Customer
			{
				CustomerID = "PICCO",
				CompanyName = "Piccolo und mehr",
				Address = "Geislweg 14",
				City = "Salzburg",
				Region = "",
				PostalCode = "5020",
				Country = "Austria",
				Phone = "6562-9722",
				Orders = new Order[]
				{
					new() { OrderID = 10353, OrderDate = new DateTime(1996, 11, 13), Total = 8593.28m },
					new() { OrderID = 10392, OrderDate = new DateTime(1996, 12, 24), Total = 1440.00m },
					new() { OrderID = 10427, OrderDate = new DateTime(1997, 1, 27), Total = 651.00m },
					new() { OrderID = 10489, OrderDate = new DateTime(1997, 3, 28), Total = 439.20m },
					new() { OrderID = 10530, OrderDate = new DateTime(1997, 5, 8), Total = 4180.00m },
					new() { OrderID = 10597, OrderDate = new DateTime(1997, 7, 11), Total = 718.08m },
					new() { OrderID = 10686, OrderDate = new DateTime(1997, 9, 30), Total = 1404.45m },
					new() { OrderID = 10747, OrderDate = new DateTime(1997, 11, 19), Total = 1912.85m },
					new() { OrderID = 10844, OrderDate = new DateTime(1998, 1, 21), Total = 735.00m },
					new() { OrderID = 11053, OrderDate = new DateTime(1998, 4, 27), Total = 3055.00m },
				}
			},
			new Customer
			{
				CustomerID = "PRINI",
				CompanyName = "Princesa Isabel Vinhos",
				Address = "Estrada da saúde n. 58",
				City = "Lisboa",
				Region = "",
				PostalCode = "1756",
				Country = "Portugal",
				Phone = "(1) 356-5634",
				Orders = new Order[]
				{
					new() { OrderID = 10336, OrderDate = new DateTime(1996, 10, 23), Total = 285.12m },
					new() { OrderID = 10397, OrderDate = new DateTime(1996, 12, 27), Total = 716.72m },
					new() { OrderID = 10433, OrderDate = new DateTime(1997, 2, 3), Total = 851.20m },
					new() { OrderID = 10477, OrderDate = new DateTime(1997, 3, 17), Total = 558.00m },
					new() { OrderID = 10808, OrderDate = new DateTime(1998, 1, 1), Total = 1411.00m },
					new() { OrderID = 11007, OrderDate = new DateTime(1998, 4, 8), Total = 2633.90m },
				}
			},
			new Customer
			{
				CustomerID = "QUEDE",
				CompanyName = "Que Delícia",
				Address = "Rua da Panificadora, 12",
				City = "Rio de Janeiro",
				Region = "RJ",
				PostalCode = "02389-673",
				Country = "Brazil",
				Phone = "(21) 555-4252",
				Orders = new Order[]
				{
					new() { OrderID = 10261, OrderDate = new DateTime(1996, 7, 19), Total = 448.00m },
					new() { OrderID = 10291, OrderDate = new DateTime(1996, 8, 27), Total = 497.52m },
					new() { OrderID = 10379, OrderDate = new DateTime(1996, 12, 11), Total = 863.28m },
					new() { OrderID = 10421, OrderDate = new DateTime(1997, 1, 21), Total = 1194.27m },
					new() { OrderID = 10587, OrderDate = new DateTime(1997, 7, 2), Total = 807.38m },
					new() { OrderID = 10647, OrderDate = new DateTime(1997, 8, 27), Total = 636.00m },
					new() { OrderID = 10720, OrderDate = new DateTime(1997, 10, 28), Total = 550.00m },
					new() { OrderID = 10794, OrderDate = new DateTime(1997, 12, 24), Total = 314.76m },
					new() { OrderID = 10989, OrderDate = new DateTime(1998, 3, 31), Total = 1353.60m },
				}
			},
			new Customer
			{
				CustomerID = "QUEEN",
				CompanyName = "Queen Cozinha",
				Address = "Alameda dos Canàrios, 891",
				City = "São Paulo",
				Region = "SP",
				PostalCode = "05487-020",
				Country = "Brazil",
				Phone = "(11) 555-1189",
				Orders = new Order[]
				{
					new() { OrderID = 10372, OrderDate = new DateTime(1996, 12, 4), Total = 9210.90m },
					new() { OrderID = 10406, OrderDate = new DateTime(1997, 1, 7), Total = 1830.78m },
					new() { OrderID = 10487, OrderDate = new DateTime(1997, 3, 26), Total = 889.70m },
					new() { OrderID = 10637, OrderDate = new DateTime(1997, 8, 19), Total = 2761.94m },
					new() { OrderID = 10659, OrderDate = new DateTime(1997, 9, 5), Total = 1227.02m },
					new() { OrderID = 10704, OrderDate = new DateTime(1997, 10, 14), Total = 595.50m },
					new() { OrderID = 10728, OrderDate = new DateTime(1997, 11, 4), Total = 1296.75m },
					new() { OrderID = 10786, OrderDate = new DateTime(1997, 12, 19), Total = 1531.08m },
					new() { OrderID = 10868, OrderDate = new DateTime(1998, 2, 4), Total = 1920.60m },
					new() { OrderID = 10913, OrderDate = new DateTime(1998, 2, 26), Total = 768.75m },
					new() { OrderID = 10914, OrderDate = new DateTime(1998, 2, 27), Total = 537.50m },
					new() { OrderID = 10961, OrderDate = new DateTime(1998, 3, 19), Total = 1119.90m },
					new() { OrderID = 11068, OrderDate = new DateTime(1998, 5, 4), Total = 2027.08m },
				}
			},
			new Customer
			{
				CustomerID = "QUICK",
				CompanyName = "QUICK-Stop",
				Address = "Taucherstraße 10",
				City = "Cunewalde",
				Region = "",
				PostalCode = "01307",
				Country = "Germany",
				Phone = "0372-035188",
				Orders = new Order[]
				{
					new() { OrderID = 10273, OrderDate = new DateTime(1996, 8, 5), Total = 2037.28m },
					new() { OrderID = 10285, OrderDate = new DateTime(1996, 8, 20), Total = 1743.36m },
					new() { OrderID = 10286, OrderDate = new DateTime(1996, 8, 21), Total = 3016.00m },
					new() { OrderID = 10313, OrderDate = new DateTime(1996, 9, 24), Total = 182.40m },
					new() { OrderID = 10345, OrderDate = new DateTime(1996, 11, 4), Total = 2924.80m },
					new() { OrderID = 10361, OrderDate = new DateTime(1996, 11, 22), Total = 2046.24m },
					new() { OrderID = 10418, OrderDate = new DateTime(1997, 1, 17), Total = 1814.80m },
					new() { OrderID = 10451, OrderDate = new DateTime(1997, 2, 19), Total = 3849.66m },
					new() { OrderID = 10515, OrderDate = new DateTime(1997, 4, 23), Total = 9921.30m },
					new() { OrderID = 10527, OrderDate = new DateTime(1997, 5, 5), Total = 1503.00m },
					new() { OrderID = 10540, OrderDate = new DateTime(1997, 5, 19), Total = 10191.70m },
					new() { OrderID = 10549, OrderDate = new DateTime(1997, 5, 27), Total = 3554.28m },
					new() { OrderID = 10588, OrderDate = new DateTime(1997, 7, 3), Total = 3120.00m },
					new() { OrderID = 10658, OrderDate = new DateTime(1997, 9, 5), Total = 4464.60m },
					new() { OrderID = 10691, OrderDate = new DateTime(1997, 10, 3), Total = 10164.80m },
					new() { OrderID = 10694, OrderDate = new DateTime(1997, 10, 6), Total = 4825.00m },
					new() { OrderID = 10721, OrderDate = new DateTime(1997, 10, 29), Total = 923.88m },
					new() { OrderID = 10745, OrderDate = new DateTime(1997, 11, 18), Total = 4529.80m },
					new() { OrderID = 10765, OrderDate = new DateTime(1997, 12, 4), Total = 1515.60m },
					new() { OrderID = 10788, OrderDate = new DateTime(1997, 12, 22), Total = 731.50m },
					new() { OrderID = 10845, OrderDate = new DateTime(1998, 1, 21), Total = 3812.70m },
					new() { OrderID = 10865, OrderDate = new DateTime(1998, 2, 2), Total = 16387.50m },
					new() { OrderID = 10878, OrderDate = new DateTime(1998, 2, 10), Total = 1539.00m },
					new() { OrderID = 10938, OrderDate = new DateTime(1998, 3, 10), Total = 2731.88m },
					new() { OrderID = 10962, OrderDate = new DateTime(1998, 3, 19), Total = 3584.00m },
					new() { OrderID = 10991, OrderDate = new DateTime(1998, 4, 1), Total = 2296.00m },
					new() { OrderID = 10996, OrderDate = new DateTime(1998, 4, 2), Total = 560.00m },
					new() { OrderID = 11021, OrderDate = new DateTime(1998, 4, 14), Total = 6306.24m },
				}
			},
			new Customer
			{
				CustomerID = "RANCH",
				CompanyName = "Rancho grande",
				Address = "Av.del Libertador 900",
				City = "Buenos Aires",
				Region = "",
				PostalCode = "1010",
				Country = "Argentina",
				Phone = "(1) 123-5555",
				Orders = new Order[]
				{
					new() { OrderID = 10448, OrderDate = new DateTime(1997, 2, 17), Total = 443.40m },
					new() { OrderID = 10716, OrderDate = new DateTime(1997, 10, 24), Total = 706.00m },
					new() { OrderID = 10828, OrderDate = new DateTime(1998, 1, 13), Total = 932.00m },
					new() { OrderID = 10916, OrderDate = new DateTime(1998, 2, 27), Total = 686.70m },
					new() { OrderID = 11019, OrderDate = new DateTime(1998, 4, 13), Total = 76.00m },
				}
			},
			new Customer
			{
				CustomerID = "RATTC",
				CompanyName = "Rattlesnake Canyon Grocery",
				Address = "2817 Milton Dr.",
				City = "Albuquerque",
				Region = "NM",
				PostalCode = "87110",
				Country = "USA",
				Phone = "(505) 555-5939",
				Orders = new Order[]
				{
					new() { OrderID = 10262, OrderDate = new DateTime(1996, 7, 22), Total = 584.00m },
					new() { OrderID = 10272, OrderDate = new DateTime(1996, 8, 2), Total = 1456.00m },
					new() { OrderID = 10294, OrderDate = new DateTime(1996, 8, 30), Total = 1887.60m },
					new() { OrderID = 10314, OrderDate = new DateTime(1996, 9, 25), Total = 2094.30m },
					new() { OrderID = 10316, OrderDate = new DateTime(1996, 9, 27), Total = 2835.00m },
					new() { OrderID = 10346, OrderDate = new DateTime(1996, 11, 5), Total = 1618.88m },
					new() { OrderID = 10401, OrderDate = new DateTime(1997, 1, 1), Total = 3868.60m },
					new() { OrderID = 10479, OrderDate = new DateTime(1997, 3, 19), Total = 10495.60m },
					new() { OrderID = 10564, OrderDate = new DateTime(1997, 6, 10), Total = 1234.05m },
					new() { OrderID = 10569, OrderDate = new DateTime(1997, 6, 16), Total = 890.00m },
					new() { OrderID = 10598, OrderDate = new DateTime(1997, 7, 14), Total = 2388.50m },
					new() { OrderID = 10761, OrderDate = new DateTime(1997, 12, 2), Total = 507.00m },
					new() { OrderID = 10820, OrderDate = new DateTime(1998, 1, 7), Total = 1140.00m },
					new() { OrderID = 10852, OrderDate = new DateTime(1998, 1, 26), Total = 2984.00m },
					new() { OrderID = 10889, OrderDate = new DateTime(1998, 2, 16), Total = 11380.00m },
					new() { OrderID = 10988, OrderDate = new DateTime(1998, 3, 31), Total = 3574.80m },
					new() { OrderID = 11000, OrderDate = new DateTime(1998, 4, 6), Total = 903.75m },
					new() { OrderID = 11077, OrderDate = new DateTime(1998, 5, 6), Total = 1255.72m },
				}
			},
			new Customer
			{
				CustomerID = "REGGC",
				CompanyName = "Reggiani Caseifici",
				Address = "Strada Provinciale 124",
				City = "Reggio Emilia",
				Region = "",
				PostalCode = "42100",
				Country = "Italy",
				Phone = "0522-556721",
				Orders = new Order[]
				{
					new() { OrderID = 10288, OrderDate = new DateTime(1996, 8, 23), Total = 80.10m },
					new() { OrderID = 10428, OrderDate = new DateTime(1997, 1, 28), Total = 192.00m },
					new() { OrderID = 10443, OrderDate = new DateTime(1997, 2, 12), Total = 517.44m },
					new() { OrderID = 10562, OrderDate = new DateTime(1997, 6, 9), Total = 488.70m },
					new() { OrderID = 10586, OrderDate = new DateTime(1997, 7, 2), Total = 23.80m },
					new() { OrderID = 10655, OrderDate = new DateTime(1997, 9, 3), Total = 154.40m },
					new() { OrderID = 10727, OrderDate = new DateTime(1997, 11, 3), Total = 1624.50m },
					new() { OrderID = 10812, OrderDate = new DateTime(1998, 1, 2), Total = 1692.80m },
					new() { OrderID = 10908, OrderDate = new DateTime(1998, 2, 26), Total = 663.10m },
					new() { OrderID = 10942, OrderDate = new DateTime(1998, 3, 11), Total = 560.00m },
					new() { OrderID = 11010, OrderDate = new DateTime(1998, 4, 9), Total = 645.00m },
					new() { OrderID = 11062, OrderDate = new DateTime(1998, 4, 30), Total = 406.40m },
				}
			},
			new Customer
			{
				CustomerID = "RICAR",
				CompanyName = "Ricardo Adocicados",
				Address = "Av.Copacabana, 267",
				City = "Rio de Janeiro",
				Region = "RJ",
				PostalCode = "02389-890",
				Country = "Brazil",
				Phone = "(21) 555-3412",
				Orders = new Order[]
				{
					new() { OrderID = 10287, OrderDate = new DateTime(1996, 8, 22), Total = 819.00m },
					new() { OrderID = 10299, OrderDate = new DateTime(1996, 9, 6), Total = 349.50m },
					new() { OrderID = 10447, OrderDate = new DateTime(1997, 2, 14), Total = 914.40m },
					new() { OrderID = 10481, OrderDate = new DateTime(1997, 3, 20), Total = 1472.00m },
					new() { OrderID = 10563, OrderDate = new DateTime(1997, 6, 10), Total = 965.00m },
					new() { OrderID = 10622, OrderDate = new DateTime(1997, 8, 6), Total = 560.00m },
					new() { OrderID = 10648, OrderDate = new DateTime(1997, 8, 28), Total = 372.38m },
					new() { OrderID = 10813, OrderDate = new DateTime(1998, 1, 5), Total = 602.40m },
					new() { OrderID = 10851, OrderDate = new DateTime(1998, 1, 26), Total = 2603.00m },
					new() { OrderID = 10877, OrderDate = new DateTime(1998, 2, 9), Total = 1955.12m },
					new() { OrderID = 11059, OrderDate = new DateTime(1998, 4, 29), Total = 1838.00m },
				}
			},
			new Customer
			{
				CustomerID = "RICSU",
				CompanyName = "Richter Supermarkt",
				Address = "Grenzacherweg 237",
				City = "Genève",
				Region = "",
				PostalCode = "1203",
				Country = "Switzerland",
				Phone = "0897-034214",
				Orders = new Order[]
				{
					new() { OrderID = 10255, OrderDate = new DateTime(1996, 7, 12), Total = 2490.50m },
					new() { OrderID = 10419, OrderDate = new DateTime(1997, 1, 20), Total = 2097.60m },
					new() { OrderID = 10537, OrderDate = new DateTime(1997, 5, 14), Total = 1823.80m },
					new() { OrderID = 10666, OrderDate = new DateTime(1997, 9, 12), Total = 4666.94m },
					new() { OrderID = 10751, OrderDate = new DateTime(1997, 11, 24), Total = 1631.48m },
					new() { OrderID = 10758, OrderDate = new DateTime(1997, 11, 28), Total = 1644.60m },
					new() { OrderID = 10931, OrderDate = new DateTime(1998, 3, 6), Total = 799.20m },
					new() { OrderID = 10951, OrderDate = new DateTime(1998, 3, 16), Total = 458.76m },
					new() { OrderID = 11033, OrderDate = new DateTime(1998, 4, 17), Total = 3232.80m },
					new() { OrderID = 11075, OrderDate = new DateTime(1998, 5, 6), Total = 498.10m },
				}
			},
			new Customer
			{
				CustomerID = "ROMEY",
				CompanyName = "Romero y tomillo",
				Address = "Gran Vía, 1",
				City = "Madrid",
				Region = "",
				PostalCode = "28001",
				Country = "Spain",
				Phone = "(91) 745 6200",
				Orders = new Order[]
				{
					new() { OrderID = 10281, OrderDate = new DateTime(1996, 8, 14), Total = 86.50m },
					new() { OrderID = 10282, OrderDate = new DateTime(1996, 8, 15), Total = 155.40m },
					new() { OrderID = 10306, OrderDate = new DateTime(1996, 9, 16), Total = 498.50m },
					new() { OrderID = 10917, OrderDate = new DateTime(1998, 3, 2), Total = 365.89m },
					new() { OrderID = 11013, OrderDate = new DateTime(1998, 4, 9), Total = 361.00m },
				}
			},
			new Customer
			{
				CustomerID = "SANTG",
				CompanyName = "Santé Gourmet",
				Address = "Erling Skakkes gate 78",
				City = "Stavern",
				Region = "",
				PostalCode = "4110",
				Country = "Norway",
				Phone = "07-98 92 35",
				Orders = new Order[]
				{
					new() { OrderID = 10387, OrderDate = new DateTime(1996, 12, 18), Total = 1058.40m },
					new() { OrderID = 10520, OrderDate = new DateTime(1997, 4, 29), Total = 200.00m },
					new() { OrderID = 10639, OrderDate = new DateTime(1997, 8, 20), Total = 500.00m },
					new() { OrderID = 10831, OrderDate = new DateTime(1998, 1, 14), Total = 2684.40m },
					new() { OrderID = 10909, OrderDate = new DateTime(1998, 2, 26), Total = 670.00m },
					new() { OrderID = 11015, OrderDate = new DateTime(1998, 4, 10), Total = 622.35m },
				}
			},
			new Customer
			{
				CustomerID = "SAVEA",
				CompanyName = "Save-a-lot Markets",
				Address = "187 Suffolk Ln.",
				City = "Boise",
				Region = "ID",
				PostalCode = "83720",
				Country = "USA",
				Phone = "(208) 555-8097",
				Orders = new Order[]
				{
					new() { OrderID = 10324, OrderDate = new DateTime(1996, 10, 8), Total = 5275.72m },
					new() { OrderID = 10393, OrderDate = new DateTime(1996, 12, 25), Total = 2556.95m },
					new() { OrderID = 10398, OrderDate = new DateTime(1996, 12, 30), Total = 2505.60m },
					new() { OrderID = 10440, OrderDate = new DateTime(1997, 2, 10), Total = 4924.14m },
					new() { OrderID = 10452, OrderDate = new DateTime(1997, 2, 20), Total = 2018.50m },
					new() { OrderID = 10510, OrderDate = new DateTime(1997, 4, 18), Total = 4707.54m },
					new() { OrderID = 10555, OrderDate = new DateTime(1997, 6, 2), Total = 2944.40m },
					new() { OrderID = 10603, OrderDate = new DateTime(1997, 7, 18), Total = 1483.00m },
					new() { OrderID = 10607, OrderDate = new DateTime(1997, 7, 22), Total = 6475.40m },
					new() { OrderID = 10612, OrderDate = new DateTime(1997, 7, 28), Total = 6375.00m },
					new() { OrderID = 10627, OrderDate = new DateTime(1997, 8, 11), Total = 1185.75m },
					new() { OrderID = 10657, OrderDate = new DateTime(1997, 9, 4), Total = 4371.60m },
					new() { OrderID = 10678, OrderDate = new DateTime(1997, 9, 23), Total = 5256.50m },
					new() { OrderID = 10700, OrderDate = new DateTime(1997, 10, 10), Total = 1638.40m },
					new() { OrderID = 10711, OrderDate = new DateTime(1997, 10, 21), Total = 4451.70m },
					new() { OrderID = 10713, OrderDate = new DateTime(1997, 10, 22), Total = 2827.90m },
					new() { OrderID = 10714, OrderDate = new DateTime(1997, 10, 22), Total = 2205.75m },
					new() { OrderID = 10722, OrderDate = new DateTime(1997, 10, 29), Total = 1570.00m },
					new() { OrderID = 10748, OrderDate = new DateTime(1997, 11, 20), Total = 2196.00m },
					new() { OrderID = 10757, OrderDate = new DateTime(1997, 11, 27), Total = 3082.00m },
					new() { OrderID = 10815, OrderDate = new DateTime(1998, 1, 5), Total = 40.00m },
					new() { OrderID = 10847, OrderDate = new DateTime(1998, 1, 22), Total = 4931.92m },
					new() { OrderID = 10882, OrderDate = new DateTime(1998, 2, 11), Total = 892.64m },
					new() { OrderID = 10894, OrderDate = new DateTime(1998, 2, 18), Total = 2753.10m },
					new() { OrderID = 10941, OrderDate = new DateTime(1998, 3, 11), Total = 4011.75m },
					new() { OrderID = 10983, OrderDate = new DateTime(1998, 3, 27), Total = 720.90m },
					new() { OrderID = 10984, OrderDate = new DateTime(1998, 3, 30), Total = 1809.75m },
					new() { OrderID = 11002, OrderDate = new DateTime(1998, 4, 6), Total = 1811.10m },
					new() { OrderID = 11030, OrderDate = new DateTime(1998, 4, 17), Total = 12615.05m },
					new() { OrderID = 11031, OrderDate = new DateTime(1998, 4, 17), Total = 2393.50m },
					new() { OrderID = 11064, OrderDate = new DateTime(1998, 5, 1), Total = 4330.40m },
				}
			},
			new Customer
			{
				CustomerID = "SEVES",
				CompanyName = "Seven Seas Imports",
				Address = "90 Wadhurst Rd.",
				City = "London",
				Region = "",
				PostalCode = "OX15 4NB",
				Country = "UK",
				Phone = "(171) 555-1717",
				Orders = new Order[]
				{
					new() { OrderID = 10359, OrderDate = new DateTime(1996, 11, 21), Total = 3471.68m },
					new() { OrderID = 10377, OrderDate = new DateTime(1996, 12, 9), Total = 863.60m },
					new() { OrderID = 10388, OrderDate = new DateTime(1996, 12, 19), Total = 1228.80m },
					new() { OrderID = 10472, OrderDate = new DateTime(1997, 3, 12), Total = 1036.80m },
					new() { OrderID = 10523, OrderDate = new DateTime(1997, 5, 1), Total = 2444.31m },
					new() { OrderID = 10547, OrderDate = new DateTime(1997, 5, 23), Total = 1792.80m },
					new() { OrderID = 10800, OrderDate = new DateTime(1997, 12, 26), Total = 1468.94m },
					new() { OrderID = 10804, OrderDate = new DateTime(1997, 12, 30), Total = 2278.40m },
					new() { OrderID = 10869, OrderDate = new DateTime(1998, 2, 4), Total = 1630.00m },
				}
			},
			new Customer
			{
				CustomerID = "SIMOB",
				CompanyName = "Simons bistro",
				Address = "Vinbæltet 34",
				City = "København",
				Region = "",
				PostalCode = "1734",
				Country = "Denmark",
				Phone = "31 12 34 56",
				Orders = new Order[]
				{
					new() { OrderID = 10341, OrderDate = new DateTime(1996, 10, 29), Total = 352.60m },
					new() { OrderID = 10417, OrderDate = new DateTime(1997, 1, 16), Total = 11188.40m },
					new() { OrderID = 10556, OrderDate = new DateTime(1997, 6, 3), Total = 835.20m },
					new() { OrderID = 10642, OrderDate = new DateTime(1997, 8, 22), Total = 696.00m },
					new() { OrderID = 10669, OrderDate = new DateTime(1997, 9, 15), Total = 570.00m },
					new() { OrderID = 10802, OrderDate = new DateTime(1997, 12, 29), Total = 2942.81m },
					new() { OrderID = 11074, OrderDate = new DateTime(1998, 5, 6), Total = 232.08m },
				}
			},
			new Customer
			{
				CustomerID = "SPECD",
				CompanyName = "Spécialités du monde",
				Address = "25, rue Lauriston",
				City = "Paris",
				Region = "",
				PostalCode = "75016",
				Country = "France",
				Phone = "(1) 47.55.60.10",
				Orders = new Order[]
				{
					new() { OrderID = 10738, OrderDate = new DateTime(1997, 11, 12), Total = 52.35m },
					new() { OrderID = 10907, OrderDate = new DateTime(1998, 2, 25), Total = 108.50m },
					new() { OrderID = 10964, OrderDate = new DateTime(1998, 3, 20), Total = 2052.50m },
					new() { OrderID = 11043, OrderDate = new DateTime(1998, 4, 22), Total = 210.00m },
				}
			},
			new Customer
			{
				CustomerID = "SPLIR",
				CompanyName = "Split Rail Beer & Ale",
				Address = "P.O.Box 555",
				City = "Lander",
				Region = "WY",
				PostalCode = "82520",
				Country = "USA",
				Phone = "(307) 555-4680",
				Orders = new Order[]
				{
					new() { OrderID = 10271, OrderDate = new DateTime(1996, 8, 1), Total = 48.00m },
					new() { OrderID = 10329, OrderDate = new DateTime(1996, 10, 15), Total = 4578.43m },
					new() { OrderID = 10349, OrderDate = new DateTime(1996, 11, 8), Total = 141.60m },
					new() { OrderID = 10369, OrderDate = new DateTime(1996, 12, 2), Total = 2390.40m },
					new() { OrderID = 10385, OrderDate = new DateTime(1996, 12, 17), Total = 691.20m },
					new() { OrderID = 10432, OrderDate = new DateTime(1997, 1, 31), Total = 485.00m },
					new() { OrderID = 10756, OrderDate = new DateTime(1997, 11, 27), Total = 1990.00m },
					new() { OrderID = 10821, OrderDate = new DateTime(1998, 1, 8), Total = 678.00m },
					new() { OrderID = 10974, OrderDate = new DateTime(1998, 3, 25), Total = 439.00m },
				}
			},
			new Customer
			{
				CustomerID = "SUPRD",
				CompanyName = "Suprêmes délices",
				Address = "Boulevard Tirou, 255",
				City = "Charleroi",
				Region = "",
				PostalCode = "B-6000",
				Country = "Belgium",
				Phone = "(071) 23 67 22 20",
				Orders = new Order[]
				{
					new() { OrderID = 10252, OrderDate = new DateTime(1996, 7, 9), Total = 3597.90m },
					new() { OrderID = 10302, OrderDate = new DateTime(1996, 9, 10), Total = 2708.80m },
					new() { OrderID = 10458, OrderDate = new DateTime(1997, 2, 26), Total = 3891.00m },
					new() { OrderID = 10463, OrderDate = new DateTime(1997, 3, 4), Total = 713.30m },
					new() { OrderID = 10475, OrderDate = new DateTime(1997, 3, 14), Total = 1505.18m },
					new() { OrderID = 10767, OrderDate = new DateTime(1997, 12, 5), Total = 28.00m },
					new() { OrderID = 10841, OrderDate = new DateTime(1998, 1, 20), Total = 4581.00m },
					new() { OrderID = 10846, OrderDate = new DateTime(1998, 1, 22), Total = 1112.00m },
					new() { OrderID = 10885, OrderDate = new DateTime(1998, 2, 12), Total = 1209.00m },
					new() { OrderID = 10930, OrderDate = new DateTime(1998, 3, 6), Total = 2255.50m },
					new() { OrderID = 11035, OrderDate = new DateTime(1998, 4, 20), Total = 1754.50m },
					new() { OrderID = 11038, OrderDate = new DateTime(1998, 4, 21), Total = 732.60m },
				}
			},
			new Customer
			{
				CustomerID = "THEBI",
				CompanyName = "The Big Cheese",
				Address = "89 Jefferson Way, Suite 2",
				City = "Portland",
				Region = "OR",
				PostalCode = "97201",
				Country = "USA",
				Phone = "(503) 555-3612",
				Orders = new Order[]
				{
					new() { OrderID = 10310, OrderDate = new DateTime(1996, 9, 20), Total = 336.00m },
					new() { OrderID = 10708, OrderDate = new DateTime(1997, 10, 17), Total = 180.40m },
					new() { OrderID = 10805, OrderDate = new DateTime(1997, 12, 30), Total = 2775.00m },
					new() { OrderID = 10992, OrderDate = new DateTime(1998, 4, 1), Total = 69.60m },
				}
			},
			new Customer
			{
				CustomerID = "THECR",
				CompanyName = "The Cracker Box",
				Address = "55 Grizzly Peak Rd.",
				City = "Butte",
				Region = "MT",
				PostalCode = "59801",
				Country = "USA",
				Phone = "(406) 555-5834",
				Orders = new Order[]
				{
					new() { OrderID = 10624, OrderDate = new DateTime(1997, 8, 7), Total = 1393.24m },
					new() { OrderID = 10775, OrderDate = new DateTime(1997, 12, 12), Total = 228.00m },
					new() { OrderID = 11003, OrderDate = new DateTime(1998, 4, 6), Total = 326.00m },
				}
			},
			new Customer
			{
				CustomerID = "TOMSP",
				CompanyName = "Toms Spezialitäten",
				Address = "Luisenstr. 48",
				City = "Münster",
				Region = "",
				PostalCode = "44087",
				Country = "Germany",
				Phone = "0251-031259",
				Orders = new Order[]
				{
					new() { OrderID = 10438, OrderDate = new DateTime(1997, 2, 6), Total = 454.00m },
					new() { OrderID = 10446, OrderDate = new DateTime(1997, 2, 14), Total = 246.24m },
					new() { OrderID = 10548, OrderDate = new DateTime(1997, 5, 26), Total = 240.10m },
					new() { OrderID = 10608, OrderDate = new DateTime(1997, 7, 23), Total = 1064.00m },
					new() { OrderID = 10967, OrderDate = new DateTime(1998, 3, 23), Total = 910.40m },
				}
			},
			new Customer
			{
				CustomerID = "TORTU",
				CompanyName = "Tortuga Restaurante",
				Address = "Avda.Azteca 123",
				City = "México D.F.",
				Region = "",
				PostalCode = "05033",
				Country = "Mexico",
				Phone = "(5) 555-2933",
				Orders = new Order[]
				{
					new() { OrderID = 10276, OrderDate = new DateTime(1996, 8, 8), Total = 420.00m },
					new() { OrderID = 10293, OrderDate = new DateTime(1996, 8, 29), Total = 848.70m },
					new() { OrderID = 10304, OrderDate = new DateTime(1996, 9, 12), Total = 954.40m },
					new() { OrderID = 10319, OrderDate = new DateTime(1996, 10, 2), Total = 1191.20m },
					new() { OrderID = 10518, OrderDate = new DateTime(1997, 4, 25), Total = 4150.05m },
					new() { OrderID = 10576, OrderDate = new DateTime(1997, 6, 23), Total = 838.45m },
					new() { OrderID = 10676, OrderDate = new DateTime(1997, 9, 22), Total = 534.85m },
					new() { OrderID = 10842, OrderDate = new DateTime(1998, 1, 20), Total = 975.00m },
					new() { OrderID = 10915, OrderDate = new DateTime(1998, 2, 27), Total = 539.50m },
					new() { OrderID = 11069, OrderDate = new DateTime(1998, 5, 4), Total = 360.00m },
				}
			},
			new Customer
			{
				CustomerID = "TRADH",
				CompanyName = "Tradição Hipermercados",
				Address = "Av.Inês de Castro, 414",
				City = "São Paulo",
				Region = "SP",
				PostalCode = "05634-030",
				Country = "Brazil",
				Phone = "(11) 555-2167",
				Orders = new Order[]
				{
					new() { OrderID = 10249, OrderDate = new DateTime(1996, 7, 5), Total = 1863.40m },
					new() { OrderID = 10292, OrderDate = new DateTime(1996, 8, 28), Total = 1296.00m },
					new() { OrderID = 10496, OrderDate = new DateTime(1997, 4, 4), Total = 190.00m },
					new() { OrderID = 10606, OrderDate = new DateTime(1997, 7, 22), Total = 1130.40m },
					new() { OrderID = 10830, OrderDate = new DateTime(1998, 1, 13), Total = 1974.00m },
					new() { OrderID = 10834, OrderDate = new DateTime(1998, 1, 15), Total = 1432.71m },
					new() { OrderID = 10839, OrderDate = new DateTime(1998, 1, 19), Total = 827.55m },
				}
			},
			new Customer
			{
				CustomerID = "TRAIH",
				CompanyName = "Trail's Head Gourmet Provisioners",
				Address = "722 DaVinci Blvd.",
				City = "Kirkland",
				Region = "WA",
				PostalCode = "98034",
				Country = "USA",
				Phone = "(206) 555-8257",
				Orders = new Order[]
				{
					new() { OrderID = 10574, OrderDate = new DateTime(1997, 6, 19), Total = 764.30m },
					new() { OrderID = 10577, OrderDate = new DateTime(1997, 6, 23), Total = 569.00m },
					new() { OrderID = 10822, OrderDate = new DateTime(1998, 1, 8), Total = 237.90m },
				}
			},
			new Customer
			{
				CustomerID = "VAFFE",
				CompanyName = "Vaffeljernet",
				Address = "Smagsløget 45",
				City = "Århus",
				Region = "",
				PostalCode = "8200",
				Country = "Denmark",
				Phone = "86 21 32 43",
				Orders = new Order[]
				{
					new() { OrderID = 10367, OrderDate = new DateTime(1996, 11, 28), Total = 834.20m },
					new() { OrderID = 10399, OrderDate = new DateTime(1996, 12, 31), Total = 1765.60m },
					new() { OrderID = 10465, OrderDate = new DateTime(1997, 3, 5), Total = 2518.00m },
					new() { OrderID = 10591, OrderDate = new DateTime(1997, 7, 7), Total = 812.50m },
					new() { OrderID = 10602, OrderDate = new DateTime(1997, 7, 17), Total = 48.75m },
					new() { OrderID = 10688, OrderDate = new DateTime(1997, 10, 1), Total = 3160.60m },
					new() { OrderID = 10744, OrderDate = new DateTime(1997, 11, 17), Total = 736.00m },
					new() { OrderID = 10769, OrderDate = new DateTime(1997, 12, 8), Total = 1684.28m },
					new() { OrderID = 10921, OrderDate = new DateTime(1998, 3, 3), Total = 1936.00m },
					new() { OrderID = 10946, OrderDate = new DateTime(1998, 3, 12), Total = 1407.50m },
					new() { OrderID = 10994, OrderDate = new DateTime(1998, 4, 2), Total = 940.50m },
				}
			},
			new Customer
			{
				CustomerID = "VICTE",
				CompanyName = "Victuailles en stock",
				Address = "2, rue du Commerce",
				City = "Lyon",
				Region = "",
				PostalCode = "69004",
				Country = "France",
				Phone = "78.32.54.86",
				Orders = new Order[]
				{
					new() { OrderID = 10251, OrderDate = new DateTime(1996, 7, 8), Total = 654.06m },
					new() { OrderID = 10334, OrderDate = new DateTime(1996, 10, 21), Total = 144.80m },
					new() { OrderID = 10450, OrderDate = new DateTime(1997, 2, 19), Total = 425.12m },
					new() { OrderID = 10459, OrderDate = new DateTime(1997, 2, 27), Total = 1659.20m },
					new() { OrderID = 10478, OrderDate = new DateTime(1997, 3, 18), Total = 471.20m },
					new() { OrderID = 10546, OrderDate = new DateTime(1997, 5, 23), Total = 2812.00m },
					new() { OrderID = 10806, OrderDate = new DateTime(1997, 12, 31), Total = 439.60m },
					new() { OrderID = 10814, OrderDate = new DateTime(1998, 1, 5), Total = 1788.45m },
					new() { OrderID = 10843, OrderDate = new DateTime(1998, 1, 21), Total = 159.00m },
					new() { OrderID = 10850, OrderDate = new DateTime(1998, 1, 23), Total = 629.00m },
				}
			},
			new Customer
			{
				CustomerID = "VINET",
				CompanyName = "Vins et alcools Chevalier",
				Address = "59 rue de l'Abbaye",
				City = "Reims",
				Region = "",
				PostalCode = "51100",
				Country = "France",
				Phone = "26.47.15.10",
				Orders = new Order[]
				{
					new() { OrderID = 10274, OrderDate = new DateTime(1996, 8, 6), Total = 538.60m },
					new() { OrderID = 10295, OrderDate = new DateTime(1996, 9, 2), Total = 121.60m },
					new() { OrderID = 10737, OrderDate = new DateTime(1997, 11, 11), Total = 139.80m },
					new() { OrderID = 10739, OrderDate = new DateTime(1997, 11, 12), Total = 240.00m },
				}
			},
			new Customer
			{
				CustomerID = "WANDK",
				CompanyName = "Die Wandernde Kuh",
				Address = "Adenauerallee 900",
				City = "Stuttgart",
				Region = "",
				PostalCode = "70563",
				Country = "Germany",
				Phone = "0711-020361",
				Orders = new Order[]
				{
					new() { OrderID = 10301, OrderDate = new DateTime(1996, 9, 9), Total = 755.00m },
					new() { OrderID = 10312, OrderDate = new DateTime(1996, 9, 23), Total = 1614.80m },
					new() { OrderID = 10348, OrderDate = new DateTime(1996, 11, 7), Total = 363.60m },
					new() { OrderID = 10356, OrderDate = new DateTime(1996, 11, 18), Total = 1106.40m },
					new() { OrderID = 10513, OrderDate = new DateTime(1997, 4, 22), Total = 1942.00m },
					new() { OrderID = 10632, OrderDate = new DateTime(1997, 8, 14), Total = 589.00m },
					new() { OrderID = 10640, OrderDate = new DateTime(1997, 8, 21), Total = 708.75m },
					new() { OrderID = 10651, OrderDate = new DateTime(1997, 9, 1), Total = 397.80m },
					new() { OrderID = 10668, OrderDate = new DateTime(1997, 9, 15), Total = 625.28m },
					new() { OrderID = 11046, OrderDate = new DateTime(1998, 4, 23), Total = 1485.80m },
				}
			},
			new Customer
			{
				CustomerID = "WARTH",
				CompanyName = "Wartian Herkku",
				Address = "Torikatu 38",
				City = "Oulu",
				Region = "",
				PostalCode = "90110",
				Country = "Finland",
				Phone = "981-443655",
				Orders = new Order[]
				{
					new() { OrderID = 10266, OrderDate = new DateTime(1996, 7, 26), Total = 346.56m },
					new() { OrderID = 10270, OrderDate = new DateTime(1996, 8, 1), Total = 1376.00m },
					new() { OrderID = 10320, OrderDate = new DateTime(1996, 10, 3), Total = 516.00m },
					new() { OrderID = 10333, OrderDate = new DateTime(1996, 10, 18), Total = 877.20m },
					new() { OrderID = 10412, OrderDate = new DateTime(1997, 1, 13), Total = 334.80m },
					new() { OrderID = 10416, OrderDate = new DateTime(1997, 1, 16), Total = 720.00m },
					new() { OrderID = 10437, OrderDate = new DateTime(1997, 2, 5), Total = 393.00m },
					new() { OrderID = 10455, OrderDate = new DateTime(1997, 2, 24), Total = 2684.00m },
					new() { OrderID = 10526, OrderDate = new DateTime(1997, 5, 5), Total = 1151.40m },
					new() { OrderID = 10553, OrderDate = new DateTime(1997, 5, 30), Total = 1546.30m },
					new() { OrderID = 10583, OrderDate = new DateTime(1997, 6, 30), Total = 2237.50m },
					new() { OrderID = 10636, OrderDate = new DateTime(1997, 8, 19), Total = 629.50m },
					new() { OrderID = 10750, OrderDate = new DateTime(1997, 11, 21), Total = 1590.56m },
					new() { OrderID = 10781, OrderDate = new DateTime(1997, 12, 17), Total = 975.88m },
					new() { OrderID = 11025, OrderDate = new DateTime(1998, 4, 15), Total = 270.00m },
				}
			},
			new Customer
			{
				CustomerID = "WELLI",
				CompanyName = "Wellington Importadora",
				Address = "Rua do Mercado, 12",
				City = "Resende",
				Region = "SP",
				PostalCode = "08737-363",
				Country = "Brazil",
				Phone = "(14) 555-8122",
				Orders = new Order[]
				{
					new() { OrderID = 10256, OrderDate = new DateTime(1996, 7, 15), Total = 517.80m },
					new() { OrderID = 10420, OrderDate = new DateTime(1997, 1, 21), Total = 1707.84m },
					new() { OrderID = 10585, OrderDate = new DateTime(1997, 7, 1), Total = 142.50m },
					new() { OrderID = 10644, OrderDate = new DateTime(1997, 8, 25), Total = 1371.80m },
					new() { OrderID = 10803, OrderDate = new DateTime(1997, 12, 30), Total = 1193.01m },
					new() { OrderID = 10809, OrderDate = new DateTime(1998, 1, 1), Total = 140.00m },
					new() { OrderID = 10900, OrderDate = new DateTime(1998, 2, 20), Total = 33.75m },
					new() { OrderID = 10905, OrderDate = new DateTime(1998, 2, 24), Total = 342.00m },
					new() { OrderID = 10935, OrderDate = new DateTime(1998, 3, 9), Total = 619.50m },
				}
			},
			new Customer
			{
				CustomerID = "WHITC",
				CompanyName = "White Clover Markets",
				Address = "305 - 14th Ave.S.Suite 3B",
				City = "Seattle",
				Region = "WA",
				PostalCode = "98128",
				Country = "USA",
				Phone = "(206) 555-4112",
				Orders = new Order[]
				{
					new() { OrderID = 10269, OrderDate = new DateTime(1996, 7, 31), Total = 642.20m },
					new() { OrderID = 10344, OrderDate = new DateTime(1996, 11, 1), Total = 2296.00m },
					new() { OrderID = 10469, OrderDate = new DateTime(1997, 3, 10), Total = 956.68m },
					new() { OrderID = 10483, OrderDate = new DateTime(1997, 3, 24), Total = 668.80m },
					new() { OrderID = 10504, OrderDate = new DateTime(1997, 4, 11), Total = 1388.50m },
					new() { OrderID = 10596, OrderDate = new DateTime(1997, 7, 11), Total = 1180.88m },
					new() { OrderID = 10693, OrderDate = new DateTime(1997, 10, 6), Total = 2071.20m },
					new() { OrderID = 10696, OrderDate = new DateTime(1997, 10, 8), Total = 996.00m },
					new() { OrderID = 10723, OrderDate = new DateTime(1997, 10, 30), Total = 468.45m },
					new() { OrderID = 10740, OrderDate = new DateTime(1997, 11, 13), Total = 1416.00m },
					new() { OrderID = 10861, OrderDate = new DateTime(1998, 1, 30), Total = 3523.40m },
					new() { OrderID = 10904, OrderDate = new DateTime(1998, 2, 24), Total = 1924.25m },
					new() { OrderID = 11032, OrderDate = new DateTime(1998, 4, 17), Total = 8902.50m },
					new() { OrderID = 11066, OrderDate = new DateTime(1998, 5, 1), Total = 928.75m },
				}
			},
			new Customer
			{
				CustomerID = "WILMK",
				CompanyName = "Wilman Kala",
				Address = "Keskuskatu 45",
				City = "Helsinki",
				Region = "",
				PostalCode = "21240",
				Country = "Finland",
				Phone = "90-224 8858",
				Orders = new Order[]
				{
					new() { OrderID = 10248, OrderDate = new DateTime(1996, 7, 4), Total = 440.00m },
					new() { OrderID = 10615, OrderDate = new DateTime(1997, 7, 30), Total = 120.00m },
					new() { OrderID = 10673, OrderDate = new DateTime(1997, 9, 18), Total = 412.35m },
					new() { OrderID = 10695, OrderDate = new DateTime(1997, 10, 7), Total = 642.00m },
					new() { OrderID = 10873, OrderDate = new DateTime(1998, 2, 6), Total = 336.80m },
					new() { OrderID = 10879, OrderDate = new DateTime(1998, 2, 10), Total = 611.30m },
					new() { OrderID = 10910, OrderDate = new DateTime(1998, 2, 26), Total = 452.90m },
					new() { OrderID = 11005, OrderDate = new DateTime(1998, 4, 7), Total = 586.00m },
				}
			},
			new Customer
			{
				CustomerID = "WOLZA",
				CompanyName = "Wolski Zajazd",
				Address = "ul.Filtrowa 68",
				City = "Warszawa",
				Region = "",
				PostalCode = "01-012",
				Country = "Poland",
				Phone = "(26) 642-7012",
				Orders = new Order[]
				{
					new() { OrderID = 10374, OrderDate = new DateTime(1996, 12, 5), Total = 459.00m },
					new() { OrderID = 10611, OrderDate = new DateTime(1997, 7, 25), Total = 808.00m },
					new() { OrderID = 10792, OrderDate = new DateTime(1997, 12, 23), Total = 399.85m },
					new() { OrderID = 10870, OrderDate = new DateTime(1998, 2, 4), Total = 160.00m },
					new() { OrderID = 10906, OrderDate = new DateTime(1998, 2, 25), Total = 427.50m },
					new() { OrderID = 10998, OrderDate = new DateTime(1998, 4, 3), Total = 686.00m },
					new() { OrderID = 11044, OrderDate = new DateTime(1998, 4, 23), Total = 591.60m },
				}
			},
		};
	}
}

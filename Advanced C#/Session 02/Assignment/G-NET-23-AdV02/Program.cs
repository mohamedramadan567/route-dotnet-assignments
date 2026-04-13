namespace G_NET_23_AdV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 }
            };

            #region Smart Product Search
            //List<Product> ElectronicsProducts = SearchProducts(catalog, x => x.Category == "Electronics");
            //List<Product> Under50 = SearchProducts(catalog, x => x.Price < 50);
            //List<Product> ProductsInStock = SearchProducts(catalog, x => x.Stock > 0);
            //List<Product> ClothingUnder100 = SearchProducts(catalog, x => (x.Category == "Clothing" && x.Price < 100));
            //Console.WriteLine("--- Electronics — ");
            //foreach (var item in ElectronicsProducts)
            //{
            //    Console.WriteLine($"{item.Name} - ${item.Price} (Stock: {item.Stock})");
            //}

            //Console.WriteLine("\n\n--- Under $50 — ");
            //foreach (var item in Under50)
            //{
            //    Console.WriteLine($"{item.Name} - ${item.Price} (Stock: {item.Stock})");
            //}

            //Console.WriteLine("\n\n--- Products in stock — ");
            //foreach (var item in ProductsInStock)
            //{
            //    Console.WriteLine($"{item.Name} - ${item.Price} (Stock: {item.Stock})");
            //}

            //Console.WriteLine("\n\n--- Clothing Under $100 — ");
            //foreach (var item in ClothingUnder100)
            //{
            //    Console.WriteLine($"{item.Name} - ${item.Price} (Stock: {item.Stock})");
            //} 
            #endregion


            #region Custom Report Generator
            //Console.WriteLine("--- Short Report ---  ");
            //PrintReport(catalog, product => Console.WriteLine($"{product.Name} - ${product.Price}"));


            //Console.WriteLine("\n\n--- Detailed Report ---  ");
            //PrintReport(catalog, product => Console.WriteLine($"[{product.Category}] {product.Name} | Price ${product.Price} | Stock: {product.Stock}"));
            #endregion

            #region Transform Products
            //List<string> summaryList = TransformProducts(catalog, product => $"{product.Name} (${product.Price})");
            //List<string> priceLabel = TransformProducts(catalog, product => $"{product.Name}: {(product.Price > 100 ? "Expensive!" : "Affordable")}");

            //Console.WriteLine("--- Summary List ---");
            //foreach (string item in summaryList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n\n--- Price Labels  ---");
            //foreach (string item in priceLabel)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Filter Products
            //List<Product> filteredProducts = FilterProducts(catalog, product => product.Stock < 20);
            //Console.WriteLine("--- Low-Stock Alert --- ");
            //foreach (Product item in filteredProducts)
            //{
            //    Console.WriteLine($"[LOW STOCK] {item.Name}: only {item.Stock} left!");
            //}
            #endregion

        }

        //I use Func Delegate because i want function to return bool and accept one parameter 
        //can replace Func<Product, bool> to Predicate<Product>.
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> condition)
        {
            List<Product> results = new();
            foreach (Product product in products)
            {
                if(condition.Invoke(product))
                {
                    results.Add(product);
                }
            }
            return results;
        }

        //I use Action Delegete because i want function don't return anything(return void).
        public static void PrintReport(List<Product>products, Action<Product> print)
        {
            foreach (Product product in products)
            {
                print.Invoke(product);
            }
        }

        //I explain it in SearchProducts Method
        public static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
        {
            List<string> results = new();
            foreach (Product product in products)
            {
                results.Add(transform.Invoke(product));
            }
            return results;
        }

        //I use Predicate because i just function retun bool and accept one parameter.
        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> filter)
        {
            List<Product> filteredProducts = new();
            foreach (Product product in products)
            {
                if (filter.Invoke(product))
                    filteredProducts.Add(product);
            }
            return filteredProducts;
        }
    }
}

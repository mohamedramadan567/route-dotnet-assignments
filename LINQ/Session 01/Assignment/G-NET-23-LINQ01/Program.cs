using G_NET_23_LINQ01.Helpers;
using G_NET_23_LINQ01.Models;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static G_NET_23_LINQ01.DataSources.Source;

namespace G_NET_23_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            ////1.Get all products from the "Seafood" category.Print each
            ////product's name and price
            //var result = ProductList.Where(p => p.Category == "Seafood")
            //                        .Select(p => new { p.ProductName, p.UnitPrice });

            #endregion

            #region Question02
            ////2.Get a list of only the product names from ProductList.Print
            ////each name.
            //var result = ProductList.Select(p => p.ProductName);

            #endregion

            #region Question03
            ////3. Sort all products by UnitPrice (ascending). Print each 
            ////product's name and price.
            //var result = ProductList.OrderBy(p => p.UnitPrice)
            //                        .Select(p => new { p.ProductName, p.UnitPrice });

            #endregion

            #region Question04
            ////4.Get all products where UnitPrice is between 10 and 30
            //var result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            #endregion

            #region Question05
            ////5. Get all products that are in stock (UnitsInStock > 0) and 
            ////belong to the "Condiments" category. 
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            #endregion

            #region Question06
            ////6. Create a new anonymous type with three properties: 
            ////● Name → the product name 
            ////● Price → the unit price 
            ////● StockStatus → a string: "Available" if UnitsInStock > 0, 
            ////otherwise "Out of Stock" 
            ////● Print the result. 
            //var result = ProductList
            //    .Select(p =>
            //    new
            //    {
            //        Name = p.ProductName,
            //        Price = p.UnitPrice,
            //        StockStatus = (p.UnitsInStock > 0 ? "Available" : "Out of Stock")
            //    });

            #endregion

            #region Question07
            ////7. Print each product's name along with its position (1-based) 
            ////in the list. Expected format: 1. Chai, 2. Chang, etc.
            //var result = ProductList.Select((p, i) => $"{i + 1}. {p.ProductName}");
            #endregion

            #region Question08
            ////8. Sort ProductList by Category ascending, then within each 
            ////category, sort by UnitPrice descending. 
            //var result = ProductList.OrderBy(p => p.Category)
            //                        .ThenByDescending(p => p.UnitPrice);
            #endregion

            #region Question09
            ////9. Get all products from the "Beverages" category, sorted by 
            ////UnitsInStock descending. Print name and stock.
            //var result = ProductList.Where(p => p.Category == "Beverages")
            //                        .OrderByDescending(p => p.UnitsInStock)
            //                        .Select(p => new { p.ProductName, p.UnitsInStock });

            #endregion

            #region Question10
            ////10. Using QUERY SYNTAX with a compound from clause, list 
            ////all orders placed in 1997 or later showing CustomerID and 
            ////OrderDate. 
            //var result = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new { c.CustomerID, o.OrderDate };


            #endregion

            #region Question11
            ////11.Show position number alongside ProductName
            //var result = ProductList.Select((p, i) => $"{i + 1}. {p.ProductName}");
            #endregion

            #region Question12
            ////12. Sort first by-word length and then by a 
            ////case-insensitive sort of the words in an array. 
            //String[] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            //var result = Arr.OrderBy(a => a.Length)
            //                .ThenBy(a => a, new StringCaseInsensitiveComparer());
            #endregion

            #region Question13
            //13. Create a list of all digits in the array whose second 
            //letter is 'i' that is reversed from the order in the 
            //original array.
            string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            var result = Arr.Where(a => a[1] == 'i').Reverse().ToList();

            #endregion

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

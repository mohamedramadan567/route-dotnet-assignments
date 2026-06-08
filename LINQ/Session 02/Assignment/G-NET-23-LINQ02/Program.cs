using G_NET_23_LINQ02.Helpers;
using G_NET_23_LINQ02.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.ConstrainedExecution;
using static G_NET_23_LINQ02.DataSources.Source;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_23_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1.Get top 3 most expensive products
            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            #endregion

            #region Question02
            ////2.show page 2 of products, with page size = 5
            //var result = ProductList.Skip((2 - 1) * 5).Take(5);

            #endregion

            #region Question03
            ////3. Take products from the list as long as Their UnitPrice is less than 
            ////$25 (list is ordered by price).
            //var result = ProductList.TakeWhile(p => p.UnitPrice < 25);
            #endregion

            #region Question04
            ////4. Check if ALL products in the "Seafood" category are in stock 
            //var result = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(result);
            #endregion

            #region Question05
            ////5.Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //Console.WriteLine($"Contains(9): {ids.Contains(9)}");
            #endregion

            #region Question06
            ////6. Group all products by Category and print each group  with its product count.
            //var grouped = ProductList.GroupBy(p => p.Category);
            //foreach (var group in grouped)
            //{
            //    Console.WriteLine($"Category name: {group.Key}, Items count = {group.Key.Count()}");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Question07
            ////7.Group products by Category and project only product names per group
            //var grouped = ProductList.GroupBy(p => p.Category)
            //                         .Select(g => new
            //                         {
            //                             Category = g.Key,
            //                             Name = g.Select(p => p.ProductName)
            //                         });
            //foreach (var group in grouped)
            //{
            //    Console.WriteLine($"Category: {group.Category}");

            //    foreach (var name in group.Name)
            //    {
            //        Console.WriteLine($"  - {name}");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Question08
            ////8.Find all categories that have MORE THAN 3 products
            //var grouped = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);
            //foreach (var group in grouped)
            //{
            //    Console.WriteLine($"Category name: {group.Key}, Products count = {group.Key.Count()}");
            //}
            #endregion

            #region Question09
            ////9.Using QUERY SYNTAX, group customers by Country, and for  each
            ////group select { Country, Count, TotalOrderValue }. 
            //var result = from C in CustomerList
            //              group C by C.Country
            //                    into Countries
            //              select new
            //              {
            //                  Country = Countries.Key,
            //                  Count = Countries.Count(),
            //                  TotalOrderValue = Countries.SelectMany(c => c.Orders)
            //                                             .Sum(o => o.Total)
            //              };

            #endregion

            #region Question10
            ////10.Calculate the total number of units in stock across all products
            //var result = ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);
            #endregion

            #region Question11
            ////11.Find the CHEAPEST and MOST EXPENSIVE product prices
            //var cheapest = ProductList.Min(p => p.UnitPrice);
            //var mostExpensive = ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine($"Cheapest: {cheapest}, Most Expensive: {mostExpensive}");
            #endregion

            #region Question12
            ////12.Get a distinct list of all product categories
            //var result = ProductList.Select(p => p.Category).Distinct();
            #endregion

            #region Question13
            ////13. find product IDs that are in setA but NOT in setB 
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };      
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            #endregion

            #region Question14
            ////14. Find countries that  appear in list1 but NOT in list2 (case-insensitive). 
            //string[] list1 = { "Germany", "France", "UK", "Spain" }; 
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            #endregion

            #region Question15
            ////15. Build a Dictionary<int, Product> keyed by ProductID. Then 
            ////retrieve and print the product with ID = 18.
            //var result = ProductList.ToDictionary(p => p.ProductID);
            //Console.WriteLine(result[18]);

            #endregion

            #region Question16
            ////16.Get the first product whose price is greater than $50.
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 50);
            //Console.WriteLine(result);
            #endregion

            #region Question17
            ////17. Try to get the first product with a price > $500.  it returns null 
            ////instead of throwing
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(result);

            #endregion

            #region Question18
            ////18. Generate a multiplication table row for 7
            //var result = Enumerable.Range(1, 12).Select(a => $"{a} * 7 = {a * 7}");
            #endregion

            #region Question19
            ////19.Generate even numbers between 1 and 30.
            //var result = Enumerable.Range(1, 30).Where(n => n % 2 == 0);
            #endregion

            #region Question20
            ////20. Concatenate the first 3 product names with the first  3 
            ////customer company names into a single sequence.
            //var result = ProductList.Take(3)
            //                        .Select(p => p.ProductName)
            //                        .Concat(CustomerList.Take(3).Select(c => c.CompanyName));
            #endregion

            #region Question21
            //21. Pair each product with a customer (by position)  and produce 
            //a string "ProductName sold to CompanyName". 
            var result = ProductList.Zip(CustomerList, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");
            #endregion

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

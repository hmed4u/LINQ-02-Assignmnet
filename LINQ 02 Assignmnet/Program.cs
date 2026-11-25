using LINQ_02_Assignmnet.DataSources;
using LINQ_02_Assignmnet.DataSources;
namespace LINQ_02_Assignmnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //var result = Source.ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3);

            //foreach (var p in result)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            #endregion

            #region Question 2

            //int pageNumber = 2;
            //int pageSize = 5;

            //var result = Source.ProductList
            //    .Skip((pageNumber - 1) * pageSize)
            //    .Take(pageSize);

            //foreach (var p in result)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            #endregion

            #region Question 3

            //var result = Source.ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var p in result)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            #endregion

            #region Question 4

            //bool allInStock = Source.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);

            //Console.WriteLine($"All Seafood products in stock: {allInStock}");

            #endregion

            #region Question 5

            //int[] ids = { 3, 9, 13, 18 };

            //bool containsNine = ids.Contains(9);

            //Console.WriteLine($"Contains 9: {containsNine}");

            #endregion

            #region Question 6

            //var result = Source.ProductList.GroupBy(p => p.Category);

            //foreach (var group in result)
            //    Console.WriteLine($"{group.Key} : {group.Count()} products");

            #endregion

            #region Question 7

            //var result = Source.ProductList.GroupBy(p => p.Category, p => p.ProductName);

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var name in group)
            //        Console.WriteLine($"   {name}");
            //}

            #endregion

            #region Question 8

            //var result = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3)
            //    .Select(g => g.Key);

            //foreach (var category in result)
            //    Console.WriteLine(category);

            #endregion

            #region Question 9
            {
                //var result = from c in Source.CustomerList
                //             group c by c.Country into g
                //             select new
                //             {
                //                 Country = g.Key,
                //                 Count = g.Count(),
                //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
                //             };

                //foreach (var item in result)
                //    Console.WriteLine($"{item.Country} | {item.Count} | {item.TotalOrderValue}");
            }
            #endregion

            #region Question 10
            {
                //var totalUnits = Source.ProductList.Sum(p => p.UnitsInStock);

                //Console.WriteLine($"Total units in stock: {totalUnits}");
            }
            #endregion

            #region Question 11
            {
                //var cheapest = Source.ProductList.Min(p => p.UnitPrice);
                //var mostExpensive = Source.ProductList.Max(p => p.UnitPrice);

                //Console.WriteLine($"Cheapest price: {cheapest}");
                //Console.WriteLine($"Most expensive price: {mostExpensive}");
            }
            #endregion

            #region Question 12
            {
                //var result = Source.ProductList
                //    .Select(p => p.Category)
                //    .Distinct();

                //foreach (var category in result)
                //    Console.WriteLine(category);
            }
            #endregion

            #region Question 13
            {
                //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
                //int[] setB = { 3, 6, 9, 12, 15, 13 };

                //var result = setA.Except(setB);   

                //foreach (var id in result)
                //    Console.WriteLine(id);
            }
            #endregion

            #region Question 14
            {
            //    string[] list1 = { "Germany", "France", "UK", "Spain" };
            //    string[] list2 = { "france", "SPAIN", "Italy" };

            //    var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);   

            //    foreach (var country in result)
            //        Console.WriteLine(country);
            }
            #endregion

            #region Question 15
            {
                //var productsById = Source.ProductList.ToDictionary(p => p.ProductID);

                //var product = productsById[18];

                //Console.WriteLine($"{product.ProductID} - {product.ProductName} - {product.UnitPrice}");
            }
            #endregion

            #region Question 16
            {
                //var product = Source.ProductList.First(p => p.UnitPrice > 50);

                //Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            }
            #endregion

            #region Question 17
            {
     
                //var product = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);

                //if (product == null)
                //    Console.WriteLine("No product with price > 500 (result is null)");
                //else
                //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            }
            #endregion

            #region Question 18
            {
                //var result = Enumerable.Range(1, 10).Select(i => $"7 x {i} = {7 * i}");

                //foreach (var line in result)
                //    Console.WriteLine(line);
            }
            #endregion

            #region Question 19
            {
                //var result = Enumerable.Range(1, 30).Where(n => n % 2 == 0);

                //foreach (var n in result)
                //    Console.WriteLine(n);
            }
            #endregion

            #region Question 20
            {
                //var productNames = Source.ProductList.Take(3).Select(p => p.ProductName);
                //var customerNames = Source.CustomerList.Take(3).Select(c => c.CustomerName);

                //var result = productNames.Concat(customerNames);

                //foreach (var name in result)
                //    Console.WriteLine(name);
            }
            #endregion

            #region Question 21
            {
               
                //var result = Source.ProductList.Zip(
                //    Source.CustomerList,
                //    (p, c) => $"{p.ProductName} sold to {c.CustomerName}");

                //foreach (var line in result)
                //    Console.WriteLine(line);
            }
            #endregion
        }
    }
}

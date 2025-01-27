using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static Assignment.ListGenerator;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assignment

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1-Restriction Operators
            //1.Find all products that are out of stock.
            //var result = ProductList.Where(p => p.UnitsInStock == 0);
            //result = from p in ProductList
            //         where p.UnitsInStock == 0
            //         select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2.Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //result = from p in ProductList
            //         where p.UnitsInStock > 0 && p.UnitPrice > 3
            //         select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3.Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((a , i) => i > a.Length);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Ordering Operators
            //1.Sort a list of products by name
            //var result = ProductList.OrderBy(p => p.ProductName);
            //result = from p in ProductList
            //         orderby p.ProductName
            //         select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2.Uses a custom comparer to do a case -insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(a => a, StringComparer.OrdinalIgnoreCase);
            //result = from a in Arr
            //         orderby a, StringComparer.OrdinalIgnoreCase
            //         select a;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3.Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //result = from p in ProductList
            //         orderby p.UnitsInStock descending
            //         select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(a => a.Length).ThenBy(a => a);
            //result = from a in Arr
            //         orderby a.Length, a
            //         select a;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //5.Sort first by word length and then by a case -insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //result = from w in words
            //         orderby w.Length, (w , StringComparer.OrdinalIgnoreCase)
            //         select w;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //result = from p in ProductList
            //         orderby p.Category descending, p.UnitPrice descending
            //         select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //7.Sort first by word length and then by a case -insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            //result = from w in Arr
            //         orderby w.Length, (w, StringComparer.OrdinalIgnoreCase) descending
            //         select w;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //List<string> array = new List<string>(Arr);
            //array[1]="i";
            //var result = array.Where(a => a.Length > 1 && a[1] == "i").Reverse();
            //result = from a in array
            //         where a[1] == "i".Length
            //         select a;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Transformation Operators
            //1.Return a sequence of just the names of a list of products.
            //var result = ProductList.Select(p => p.ProductName);
            //result = from p in ProductList
            //         select p.ProductName;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"ProductName: {item}");
            //}

            //2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower(),
            //});
            //result = from p in words
            //         select new
            //         {
            //             Upper = p.ToUpper(),
            //             Lower = p.ToLower(),
            //         };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /*3.Produce a sequence containing some properties of Products, including
            UnitPrice which is renamed to Price in the resulting type.*/
            //var result = ProductList.Select(p => new
            //{
            //    ProductId = p.ProductID,
            //    ProductName = p.ProductName,
            //    Price = p.UnitPrice
            //});
            //result = from p in ProductList
            //         select new
            //         {
            //             ProductId = p.ProductID,
            //             ProductName = p.ProductName,
            //             Price = p.UnitPrice
            //         };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4.Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((p, i) => i == p);
            //result = from a in Arr
            //         select a == Arr[a];
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = from na in numbersA
            //             from nb in numbersB
            //             where na < nb
            //             select new { na, nb };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"NumberA: {item.na} Is Less Than NumberB: {item.nb}");
            //}

            //6.Select all orders where the order total is less than 500.00.
            //var result = from c in CustomerList
            //             from o in c.Orders
            //             where o.Total < 500.00m
            //             select o;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //7.Select all orders where the order was made in 1998 or later.
            var result = from c in CustomerList
                         from o in c.Orders
                         where o.OrderDate.Year >= 1998
                         select o;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}

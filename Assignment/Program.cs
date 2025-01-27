using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static Assignment.ListGenerator;
using System;
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
        }
    }
}

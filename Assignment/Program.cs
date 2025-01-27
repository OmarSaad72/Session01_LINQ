using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static Assignment.ListGenerator;
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
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var result = Arr.Where((a , i) => i > a.Length);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}

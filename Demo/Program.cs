using System;
using System.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Event
            //Ball ball = new Ball(3);
            //Player player11 = new Player("Omar", "RealMadrid");
            //Player player12 = new Player("Ali", "RealMadrid");
            //Player player21 = new Player("Mohammed", "Barcelona");
            //Player player22 = new Player("Yasser", "Barcelona");
            //Refree refree = new Refree("Johan");
            ///*******************************************************/
            //ball.OnBallChanged += player11.Run; //+= To Invvoke(Subscribe)
            //ball.OnBallChanged += player12.Run;
            //ball.OnBallChanged += player21.Run;
            //ball.OnBallChanged += player22.Run;
            ///*******************************************************/
            //ball.OnBallChanged += refree.Look;
            //ball.Location = new Location(3, 4, 6);
            ///*******************************************************/
            //Console.WriteLine("After Player11 Fired!");
            //ball.OnBallChanged -= player11.Run;  //-= To Fired(UnSubscribe)
            //ball.Location = new Location(1, 2, 3); //Change Location to see the result
            #endregion

            #region LinQ
            //List<int> Num = new List<int>(10) { 1, 2, 3, 4, 5, 7, 9 };
            //List<int> Odd =Num.Where(N => N % 2==1).ToList();
            //foreach (int i  in Odd)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region LinQ Syntax
            //List<int> Num = new List<int>(10) { 1, 2, 3, 4, 5, 7, 9 };
            //Fluent Syntax: (C# Code)
            //List<int> odd = Enumerable.Where(Num, N => N % 2 == 1).ToList(); // Static Method 
            //List<int> odd = Num.Where(N => N % 2 == 1).ToList();  // Extension Method
            //foreach (int i in odd)
            //{
            //    Console.WriteLine(i);
            //}

            // Query Syntax: (Query Expression) ==> Like SQL Server Style
            //var odd = from N in Num  // Num ==> Source
            //          where N % 2 == 1
            //          select N;
            //foreach (int i in odd)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Execution Ways
            // Deferred Execution 
            //List<int> Num = new List<int>(10) { 1, 2, 3, 4, 5, 7, 9 };
            //var result = Num.Where(N => N % 2 == 1);
            //Num.AddRange(new int[] { 11, 13, 14, 12, 15 });
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //Immediate Execution
            //List<int> Num = new List<int>(10) { 1, 2, 3, 4, 5, 7, 9 };
            //var result = Num.Where(N => N % 2 == 1).ToList();
            //Num.AddRange(new int[] { 11, 13, 14, 12, 15 });
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Data Setup

            #endregion
            #region Filtration(Restrication) Operators (where)
            //Get Product Out Of Stock:
            //var result = ProductList.Where(P => P.unitInStock == 0); //Fluent Syntax
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Get Product In Stock:
            //var result = ProductList.Where(P => P.unitInStock > 0 && P.Category = "Meat/Poultry"); //Fluent Syntax
            //var result = from P in ProductList
            //             where P.unitInStock > 0 && P.Category = "Meat/Poultry"
            //             select P; // Query Syntax
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Get Product Out Of Stock In First 10 Elements: 
            //Indexed Where
            //Valid Only Fluent Syntax
            //var result = ProductList.Where((P, I) => I < 10 && P.unitInStock == 0); //Fluent Syntax
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}

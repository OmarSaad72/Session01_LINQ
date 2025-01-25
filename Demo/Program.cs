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
            List<int> Num = new List<int>(10) { 1, 2, 3, 4, 5, 7, 9 };
            List<int> Odd =Num.Where(N => N % 2==1).ToList();
            foreach (int i  in Odd)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}

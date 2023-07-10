namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake & Ladder Simulator");
            Simulator simulator = new Simulator();
           // UC1
            simulator.StartGame();

            //UC2
            //simulator.RollingDie();

            //UC3
            //simulator.CheckOption();

            //UC4 & UC5
            simulator.WinningPosition();
        }
    }
}
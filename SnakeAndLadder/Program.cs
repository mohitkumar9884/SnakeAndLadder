namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake & Ladder Simulator");
            Simulator simulator = new Simulator();
            simulator.StartGame();
            simulator.RollingDie();
           
            
            



        }
    }
}
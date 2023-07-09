using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Simulator
    {
        //UC1
        public void StartGame()
        {
            Console.WriteLine("At Start position of Player1 is Zero");
        }
        //UC2
        public void RollingDie()
        {
            Console.WriteLine("Player1 Roll Die");
            Random random = new Random();
            int result = random.Next(1, 7);//1 or 2 or 3 or 4 or 5 or 6
            Console.WriteLine("Outcome:{0}", result);
        }
    }
}

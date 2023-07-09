using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Simulator
    {
        Random random = new Random();
        int result1 = 0;

        //UC1
        public void StartGame()
        {
            Console.WriteLine("At Start position of Player1 is Zero");
        }
        //UC2
        public void RollingDie()
        {
            Console.WriteLine("Player1 Roll Die");
      
            result1 = random.Next(1, 7);//1 or 2 or 3 or 4 or 5 or 6
            Console.WriteLine("Turn up:{0}", result1);
        }
        //UC3
        public void CheckOption()
        {
            const int N0_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;

            int  result2= random.Next(0, 3);// 0 or 1 or 2
           // Console.WriteLine("Move:{0}",result2 );

            if (result2==LADDER)
            {
                Console.WriteLine("(LADDER) Player1 move position ahead by {0}.",+result1);
            }
            else if (result2==SNAKE)
            {
                Console.WriteLine("(SNAKE) Player1 move position behind by {0}.",+result1);
            }
            else
            {
                Console.WriteLine("(NO_PLAY) Player1 stay in the same position");
            }
        }
    }
}

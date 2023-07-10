using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Simulator
    {
        Random random = new Random();
        //int result1 = 0;
        //int result2 = 0;
        const int WINNING_POSITION = 100;
        int playerPosition = 0;
        int dieRollCount = 0;
        

        //UC1
        public void StartGame()
        {
            Console.WriteLine("At Start position of Player1 is Zero");
        }
        /*UC2
        public void RollingDie()
        {
            Console.WriteLine("Player1 Roll Die");
      
            result1 = random.Next(1, 7);//1 or 2 or 3 or 4 or 5 or 6
            Console.WriteLine("Turn up:{0}", result1);
        }
        UC3
        public void CheckOption()
        {
            result2 = random.Next(0, 3);// 0 or 1 or 2
            const int N0_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
         
            //Console.WriteLine("Move:{0}",result2 );

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
                Console.WriteLine("(NO_PLAY) Player1 stay in the same position.");
            }  
        }*/
        //UC4 & UC5 & UC6
        public void WinningPosition()
        {
            
            while (playerPosition < WINNING_POSITION)
            {
                int dieRoll = RollDie();
                int option = CheckOption();

                dieRollCount++;// Increment Die Roll Count

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Player1 rolled a {0} and stays in the same position.", dieRoll);
                        break;
                    case 1:
                        Console.WriteLine("Player1 rolled a {0} and moves ahead by {1} positions.", dieRoll, dieRoll);
                        playerPosition = playerPosition + dieRoll;
                        break;
                    case 2:
                        Console.WriteLine("Player1 rolled a {0} and moves back by {1} positions.", dieRoll, dieRoll);
                        playerPosition = playerPosition - dieRoll;
                        if (playerPosition < 0)
                            playerPosition = 0;
                        break;
                }
                
                if (playerPosition > WINNING_POSITION)
                    playerPosition = playerPosition - dieRoll;

                Console.WriteLine("Current position of Player 1: {0}", playerPosition);
            }

            Console.WriteLine("Player1 wins!");
            Console.WriteLine("Total die roll: {0}", dieRollCount);
            
        }

            int RollDie()
            {
                return random.Next(1, 7); // Returns a random number between 1 and 6
            }

            int CheckOption()
            {
                return random.Next(0, 3); // Returns a random number between 0 and 2    
            }
        
    }
}

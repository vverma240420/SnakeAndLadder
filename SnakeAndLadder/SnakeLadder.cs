using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeLadder
    {
        public void Game()
        {
            //this is for first statement
            int start = 0;
            Console.WriteLine("Start Position:" + start);

            //Rolls the die
            Random random = new Random();
            int roll = random.Next(1, 7);
            Console.WriteLine("Die O/P is:" +roll);



            //It's check for position
            int playerPosition = 0;
            int ladder = 1;
            int snake = 2;
            Console.WriteLine("1:ladder\t 2: snake\t 3: notplay");
            int option = random.Next(1, 4);
            Console.WriteLine("Choosed option is: " + option);
            if (option == ladder)
            {
                playerPosition = playerPosition + roll;
                Console.WriteLine("With ladder player moves {0} steps ahead and now on {1} position ", roll, playerPosition);
            }
            else if (option == snake)
            {
                playerPosition = playerPosition - roll;
                Console.WriteLine("With snake player moves {0} steps back and now is on {1} position ", roll, playerPosition);
            }
            else
            {
                Console.WriteLine("no play player stays on its position only no movement " + playerPosition);
            }
        }
    }
}

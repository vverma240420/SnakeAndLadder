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


        }
    }
}

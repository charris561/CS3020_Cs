using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charris4Challenge1
{
    public class Game
    {

        Gameboard board = new Gameboard();

        public void Run() 
        {
            board.FillGrid();
            board.Display();
            PlayerTurn();
            board.Display();
            PlayerTurn();
            board.Display();
        }

        public void PlayerTurn()
        {
            //prompt for location
            Console.WriteLine("What's our target? ");
            string target = Console.ReadLine();

            //check if valid
            //place shot
            board.SetChar(target[0] - 65, int.Parse(target.Substring(1)) - 1, 'O');
        }

    }
}
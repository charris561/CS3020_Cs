using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charris4Battleship
{
    /// <summary>
    /// Defines a game object
    /// </summary>
    public class Game
    {
        Gameboard board = new Gameboard();

        /// <summary>
        /// Runs a game of battleship
        /// </summary>
        public void Run()
        {
            board.Display();
            PlayerTurn();
            board.Display();
        }

        /// <summary>
        /// Creates and places the computer player's ships
        /// </summary>
        public void ComputerPlaceShips() 
        {
            //create ship objects
            Ship destroyer1 = new Ship(Constants.DestroyerLength);
            Ship destroyer2 = new Ship(Constants.DestroyerLength);
            Ship submarine1 = new Ship(Constants.SubmarineLength);
            Ship submarine2 = new Ship(Constants.SubmarineLength);
            Ship battleship = new Ship(Constants.BattleshipLength);
            Ship carrier = new Ship(Constants.CarrierLength);

            //create random object to generate random numbers
            //https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
            Random rand = new Random();

            //set bow for each ship
            
        }       

        /// <summary>
        /// Defines one player turn
        /// </summary>
        public void PlayerTurn() 
        {
            //prompt for target location
            Console.WriteLine("What is our target? ");
            string target = Console.ReadLine();

            //Make coordinates out of target
            char row = Char.ToUpper(target[0]);
            int col = int.Parse(target.Substring(1)) - 1;

            //assign coordinates
            int[] targetCoords = new int[2];
            targetCoords[0] = row - 65;
            targetCoords[1] = col;

            //check if valid. If not valid, get new turn
            if (!IsValidTurn(targetCoords)) 
            {
                Console.WriteLine("Invalid Target!");
                PlayerTurn();
            }

            //place shot
            board.SetChar(targetCoords[0], targetCoords[1], HitOrMiss(targetCoords));
        }

        /// <summary>
        /// Checks if the target coordinates are valid
        /// </summary>
        /// <param name="targetCoords"></param>
        /// <returns></returns>
        private bool IsValidTurn(int[] targetCoords)
        {
            //determine if target is on board
            int row = targetCoords[0];
            int col = targetCoords[1];
            bool valid = true;

            if (row < 0 || col < 0 || row > board.Grid.GetLength(0) - 1 || col > board.Grid.GetLength(1) - 1)
            {
                valid = false;
            }

            return valid;
        }

        /// <summary>
        /// Returns a character representing a hit or miss
        /// </summary>
        /// <param name="targetCoords"></param>
        /// <returns></returns>
        private char HitOrMiss(int[] targetCoords)
        {
            return Constants.Hit;
        }
    }
}
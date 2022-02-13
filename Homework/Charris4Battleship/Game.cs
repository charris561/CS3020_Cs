using System;
using System.Collections.Generic;

namespace charris4Battleship
{
    /// <summary>
    /// Defines a game object
    /// </summary>
    public class Game
    {
        Gameboard shipBoard = new Gameboard();
        Gameboard gameboard = new Gameboard();

        //a list to store the computer's ships:
        //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0
        List<Ship> fleet = new List<Ship>();

        /// <summary>
        /// Runs a game of battleship
        /// </summary>
        public void Run()
        {
            bool userDonePlaying = false;

            while (!userDonePlaying)
            {
                ComputerPlaceShips();
                bool gameOver = false;
                bool cheats = false;
                int totalHits = 0;

                //see if user would like cheats enabled
                bool validEntry = false;
                while (!validEntry)
                {
                    Console.WriteLine($"Press {Constants.CheatNum} to enable cheats or {Constants.SkillNum} to disable them. ");
                    int userDecision = Convert.ToInt32(Console.ReadLine());

                    //validate decision
                    if (userDecision != Constants.CheatNum && userDecision != Constants.SkillNum)
                    {
                        Console.WriteLine("Invalid Entry");
                    }
                    else
                    {
                        if (userDecision == Constants.CheatNum)
                        {
                            cheats = true;
                        }

                        validEntry = true;
                    }
                }

                while (!gameOver)
                {
                    if (cheats)
                    {
                        shipBoard.Display();
                        totalHits += PlayerTurn();
                        shipBoard.Display();
                    }
                    else
                    {
                        gameboard.Display();
                        totalHits += PlayerTurn();
                        gameboard.Display();
                    }

                    if (totalHits >= (2 * Constants.DestroyerLength) + (2 * Constants.SubmarineLength) + (1 * Constants.BattleshipLength) + (1 * Constants.CarrierLength))
                    {
                        Console.WriteLine($"You have sunk the all of their ships! \nWould you like to play another game? (y)es or (n)o");

                        char userChoice = Console.ReadLine()[0];

                        if (userChoice == 'N' || userChoice == 'n')
                        {
                            userDonePlaying = true;
                        }
                        else if (userChoice == 'Y' || userChoice == 'y')
                        {
                            shipBoard.ResetGrid();
                            gameboard.ResetGrid();
                        }

                        gameOver = true;
                    }
                }
            }
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

            //define stern values for ships
            PlaceShips(destroyer1, shipBoard);
            PlaceShips(destroyer2, shipBoard);
            PlaceShips(submarine1, shipBoard);
            PlaceShips(submarine2, shipBoard);
            PlaceShips(battleship, shipBoard);
            PlaceShips(carrier, shipBoard);

            //add ships to fleet
            fleet.Add(destroyer1);
            fleet.Add(destroyer2);
            fleet.Add(submarine1);
            fleet.Add(submarine2);
            fleet.Add(battleship);
            fleet.Add(carrier);
        }

        /// <summary>
        /// Defines the stern and bow of ship and places on ship board
        /// </summary>
        public void PlaceShips(Ship aShip, Gameboard board) 
        {
            //create random object to generate random numbers
            //https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
            Random rand = new Random();
            int[] stern = new int[] { rand.Next(0, board.Grid.GetLength(0)), rand.Next(0, board.Grid.GetLength(0)) };
            int[] bow = new int[] { stern[0], stern[1] - aShip.Length };
            int vertical = rand.Next(0,2);
            bool coordsFound = false;

            //horizontal placement
            if (vertical == 0)
            {
                //if horizontal, ship's bow[1] must be less than grid size
                aShip.Orientation = "Horizontal";

                while (!coordsFound)
                {
                    //check if coordinates are valid
                    if (bow[1] >= 0 && bow[1] < Constants.GameboardSize)
                    {
                        if (board.Grid[stern[0], stern[1]] != 'S' && board.Grid[bow[0], bow[1]] != 'S')
                        {
                            coordsFound = true;

                            //check coords between stern and bow for a ship
                            for (int col = stern[1]; col > bow[1]; col--)
                            {
                                if (board.Grid[stern[0], col] == 'S')
                                {
                                    coordsFound = false;
                                }
                            }

                            if (coordsFound)
                            {
                                //fill grid with S for ships
                                for (int col = stern[1]; col > bow[1]; col--)
                                {
                                    board.SetChar(stern[0], col, 'S');
                                }
                            }
                        }
                    }
                    if (!coordsFound)
                    {
                        stern = new int[] { rand.Next(0, board.Grid.GetLength(0)), rand.Next(0, board.Grid.GetLength(0)) };
                        bow = new int[] { stern[0], stern[1] - aShip.Length };
                    }
                }
                //subtract one from bow column - coord for accurate bow on object
                bow[1] += 1;
            }

            //vertical placement
            else 
            {
                //if vertical, ship's bow[0] must be less than grid size
                aShip.Orientation = "Vertical";
                stern = new int[] { rand.Next(0, board.Grid.GetLength(0)), rand.Next(0, board.Grid.GetLength(0)) };
                bow = new int[] { stern[0] - aShip.Length, stern[1]};

                while (!coordsFound)
                {
                    //check if coordinates are valid
                    if (bow[0] >= 0 && bow[0] < Constants.GameboardSize)
                    {
                        if (board.Grid[stern[0], stern[1]] != 'S' && board.Grid[bow[0], bow[1]] != 'S')
                        {
                            coordsFound = true;

                            //check coords between stern and bow for a ship
                            for (int row = stern[0]; row > bow[0]; row--)
                            {
                                if (board.Grid[row, stern[1]] == 'S')
                                {
                                    coordsFound = false;
                                }
                            }

                            if (coordsFound)
                            {
                                //fill grid with S for ships
                                for (int row = stern[0]; row > bow[0]; row--)
                                {
                                    board.SetChar(row, stern[1], 'S');
                                }
                            }
                        }
                    }
                    if (!coordsFound)
                    {
                        stern = new int[] { rand.Next(0, board.Grid.GetLength(0)), rand.Next(0, board.Grid.GetLength(0)) };
                        bow = new int[] { stern[0] - aShip.Length, stern[1] };
                    }
                }
                //subtract one from bow row - coord for accurate bow on object
                bow[0] += 1;
            }

            //assign coordinates to ship
            aShip.Stern = stern;
            aShip.Bow = bow;
        }

        /// <summary>
        /// Defines one player turn
        /// </summary>
        public int PlayerTurn() 
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
            bool hit;
            if (HitOrMiss(targetCoords) == Constants.Hit)
            {
                Console.WriteLine("Confirmed Hit! ");
                hit = true;

                //if hit, decrement ships's health
                DecrementShipHealth(targetCoords);
            }
            else
            {
                Console.WriteLine("We missed! ");
                hit = false;
            }
            char hitOrMiss = HitOrMiss(targetCoords);
            shipBoard.SetChar(targetCoords[0], targetCoords[1], hitOrMiss);
            gameboard.SetChar(targetCoords[0], targetCoords[1], hitOrMiss);

            Console.WriteLine("Press any key to continue. ");
            Console.ReadKey();

            //return 1 for hit and 0 for miss
            if (hit)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }


        /// <summary>
        /// Finds what ship was hit and decrements that object's health
        /// </summary>
        /// <param name="targetCoords"></param>
        public void DecrementShipHealth(int[] targetCoords)
        {
            //see if stern or bow of any ship in fleet
            bool hitStern = false;
            bool hitBow = false;
            Ship shipHit = null;
            for (int i = 0; i < fleet.Count; i++)
            {
                if (targetCoords[0] == fleet[i].Stern[0] && targetCoords[1] == fleet[i].Stern[1])
                {
                    hitStern = true;
                    shipHit = fleet[i];
                }
                else if (targetCoords[0] == fleet[i].Bow[0] && targetCoords[1] == fleet[i].Bow[1])
                { 
                    hitBow = true;
                    shipHit = fleet[i];
                }
            }
            if (!hitStern && !hitBow)
            {
                //see if between bow and stern
                for (int i = 0; i < fleet.Count; i++)
                {
                    //stern[0] > bow[0]
                    if (fleet[i].Orientation == "Vertical")
                    {
                        //iterate throuch rows to see if any coords match between bow and stern
                        for (int row = fleet[i].Stern[0]; row >= fleet[i].Bow[0]; row--)
                        {
                            int[] currentCoords = {row, fleet[i].Stern[1] };
                            if (targetCoords[0] == currentCoords[0] && targetCoords[1] == currentCoords[1])
                            { 
                                shipHit = fleet[i];
                            }
                        }
                    }
                    //stern[1] > bow[1]
                    else 
                    {
                        //iterate throuch rows to see if any coords match between bow and stern
                        for (int col = fleet[i].Stern[1]; col >= fleet[i].Bow[1]; col--)
                        {
                            int[] currentCoords = { fleet[i].Stern[0], col };
                            if (targetCoords[0] == currentCoords[0] && targetCoords[1] == currentCoords[1])
                            {
                                shipHit = fleet[i];
                            }
                        }
                    }
                }
            }

            //decrement health and display message if sunk!
            if (shipHit != null)
            {
                shipHit.Health -= 1;

                if (shipHit.Health == 0)
                {
                    Console.WriteLine($"You sunk a {shipHit.Type}!");
                }
            }
        }

        /// <summary>
        /// Checks if the target coordinates are valid
        /// </summary>
        /// <param name="targetCoords"></param>
        /// <returns>
        /// True if valid, false if invalid
        /// </returns>
        private bool IsValidTurn(int[] targetCoords)
        {
            //determine if target is on board
            int row = targetCoords[0];
            int col = targetCoords[1];
            bool valid = true;

            if (row < 0 || col < 0 || row > shipBoard.Grid.GetLength(0) - 1 || col > shipBoard.Grid.GetLength(1) - 1)
            {
                valid = false;
            }

            return valid;
        }

        /// <summary>
        /// Returns a character representing a hit or miss
        /// </summary>
        /// <param name="targetCoords"></param>
        /// <returns>Hit character or miss character</returns>
        private char HitOrMiss(int[] targetCoords)
        {
            if (shipBoard.Grid[targetCoords[0], targetCoords[1]] == 'S')
            {
                return Constants.Hit;
            }
            else
            {
                return Constants.Miss;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charris4Battleship
{
    /// <summary>
    /// Defines and displays the gameboard
    /// </summary>
    public class Gameboard
    {
        /// <summary>
        /// Constructor for gameboard; calls "ResetGrid()" method
        /// </summary>
        public Gameboard()
        {
            ResetGrid();
        }

        /// <summary>
        /// Stores the state of the gameboard
        /// </summary>
        private char[,] grid = new char[Constants.GameboardSize, Constants.GameboardSize];

        /// <summary>
        /// Getter and setter for Gameboard Grid
        /// </summary>
        public char[,] Grid
        {
            get
            {
                return grid;
            }
            set
            {
                grid = value;
            }
        }

        /// <summary>
        /// Sets space [row, col] to character or displays error
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="aChar"></param>
        public void SetChar(int row, int col, char aChar)
        {
            if (row < grid.GetLength(0) && col < grid.GetLength(1))
            {
                grid[row, col] = aChar;
            }
            else
            {
                Console.WriteLine($"Invalid Location: [{row},{col}]");
            }
        }

        /// <summary>
        /// Displays the current state of the Gameboard
        /// </summary>
        public void Display()
        {
            Console.Clear();
            char rowChar = 'A';
            for (int row = 0; row < Grid.GetLength(0); row++)
            {
                DrawLine();
                Console.Write(rowChar + " ");
                rowChar++;

                for (int col = 0; col < Grid.GetLength(1); col++)
                { 
                    Console.Write($"| {Grid[row, col]} ");
                }

                Console.WriteLine("|");
            }

            DrawLine();
            DrawColumnNumbers();
        }

        /// <summary>
        /// Draws a horizontal line
        /// </summary>
        private void DrawLine()
        {
            Console.Write("  ");

            for (int i = 0; i < Grid.GetLength(1) * 4 + 1; i++)
            {
                Console.Write($"-");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Displays the column numbers for when displaying the gameboard
        /// </summary>
        private void DrawColumnNumbers()
        {
            Console.Write("  ");
            for (int i = 0; i < Grid.GetLength(1); i++)
            {
                Console.Write($"  {i + 1} ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Fills grid with the space character
        /// </summary>
        public void ResetGrid()
        {
            for (int row = 0; row < Grid.GetLength(0); row++)
            {
                for (int col = 0; col < Grid.GetLength(1); col++)
                {
                    Grid[row, col] = ' ';
                }
            }
        }
    }
}
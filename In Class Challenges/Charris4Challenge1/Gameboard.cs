using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charris4Challenge1
{
    public class Gameboard
    {

        private char[,] grid = new char[10, 10];

        //public char[,] Grid { get => grid; set => grid = value; }

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

        public void FillGrid()
        {

            for (int row = 0; row < Grid.GetLength(0); row++)
            {

                for (int col = 0; col < Grid.GetLength(1); col++)
                {

                    Grid[row, col] = 'X';

                }

            }

        }

        public void FillGrid(char aChar)
        {
            //fill grid with user entry
            for (int row = 0; row < Grid.GetLength(0); row++)
            {

                for (int col = 0; col < Grid.GetLength(1); col++)
                {

                    Grid[row, col] = aChar;

                }//For Columns

            }//For Rows
        }

        public void CheckerFill()
        {
            char a = 'X';
            char b = 'O';

            for (int row = 0; row < Grid.GetLength(0); row++)
            {

                for (int col = 0; col < Grid.GetLength(1); col++)
                {

                    Grid[row, col] = ((row + col) % 2 == 0) ? a : b;

                }

            }
        }

        public void UserFillGrid()
        {
            Console.WriteLine("Please Enter a character: ");
            //char answer = Console.ReadKey().KeyChar;
            char answer = Console.ReadLine()[0];

            FillGrid(answer);
        }

        public void Display()
        {
            char rowChar = 'A';
            for (int row = 0; row < Grid.GetLength(0); row++)
            {
                DrawLine();
                Console.Write(rowChar + " ");
                rowChar++;

                for (int col = 0; col < Grid.GetLength(1); col++)
                {

                    Console.Write($"| {Grid[row, col]} ");

                }//for col

                Console.WriteLine("|");

            }//for row

            DrawLine();
            DrawColumnNumbers();

        }

        private void DrawLine()
        {
            Console.Write("  ");
            for (int i = 0; i < Grid.GetLength(1) * 4 + 1; i++)
            {
                Console.Write($"-");
            }

            Console.WriteLine();

        }

        private void DrawColumnNumbers()
        {
            Console.Write("  ");
            for (int i = 0; i < Grid.GetLength(1); i++)
            {
                Console.Write($"  {i + 1} ");
            }

            Console.WriteLine();
        }

    }

}
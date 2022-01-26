using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charris4Challenge1
{
    public class Gameboard
    {

        char[,] grid = new char[10, 10];
        
        
        public void FillGrid(){

        for (int row = 0; row < grid.GetLength(0); row++){

            for (int col = 0; col < grid.GetLength(1); col++){

                    grid[row, col] = 'X';

                }//For Columns

            }//For Rows

        }//FillGrid

        public void Display() 
        {

            for (int row = 0; row < grid.GetLength(0); row++)
            {
                DrawLine();

                for (int col = 0; col < grid.GetLength(1); col++)
                {

                    Console.Write($"| {grid[row, col]} ");

                }//for col

                Console.WriteLine("|");

            }//for row

            DrawLine();

        }//Display

        private void DrawLine()
        {

            for (int i = 0; i < grid.GetLength(1) * 4 + 1; i++)
            {
                Console.Write($"-");
            }
            Console.WriteLine();

        }//DrawLine

    }//Gameboard

}//Charris4Challenge1
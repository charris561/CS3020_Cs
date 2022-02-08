using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charris4Battleship
{
    /// <summary>
    /// Defines a ship object
    /// </summary>
    public class Ship
    {
        private int length;
        private int[] bow;
        private int[] stern;
        private string type;


        /// <summary>
        /// Creates one ship object
        /// </summary>
        /// <param name="length"></param>
        /// <param name="bow"></param>
        /// <param name="stern"></param>
        public Ship(int length)
        {
            DefineType(length);
        }

        public void DefineCoords()
        { 
            
        }

        /// <summary>
        /// Defined the type of ship based on it's length
        /// </summary>
        /// <param name="length"></param>
        private void DefineType(int length) 
        {
            switch (length)
            {
                case Constants.DestroyerLength:
                    type = "Destroyer";
                    break;

                case Constants.SubmarineLength:
                    type = "Submarine";
                    break;

                case Constants.BattleshipLength:
                    type = "Battleship";
                    break;

                case Constants.CarrierLength:
                    type = "Carrier";
                    break;

                default:
                    type = "Unknown";
                    break;
            }
        }


    }
}
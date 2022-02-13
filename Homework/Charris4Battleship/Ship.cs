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
        private int health;
        private string orientation;


        /// <summary>
        /// Creates one ship object
        /// </summary>
        /// <param name="length"></param>
        public Ship(int length)
        {
            this.length = length;
            health = length;
            DefineType(length);
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

        /// <summary>
        /// Getter and setter for type of ship
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        /// <summary>
        /// Getter and setter for bow coordinates
        /// </summary>
        public int[] Bow
        {
            get
            {
                return bow;
            }
            set
            {
                bow = value;
            }
        }

        /// <summary>
        /// Getter and setter for stern coordinates
        /// </summary>
        public int[] Stern
        {
            get
            {
                return stern;
            }
            set
            {
                stern = value;
            }
        }

        /// <summary>
        /// Getter and setter for length of ship
        /// </summary>
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        /// <summary>
        /// Getter and setter for health of ship
        /// </summary>
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        /// <summary>
        /// Getter and setter for Orientation of ship
        /// </summary>
        public string Orientation
        {
            get
            {
                return orientation;
            }
            set
            {
                orientation = value;
            }
        }

    }
}
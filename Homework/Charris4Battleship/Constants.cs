using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charris4Battleship
{
    /// <summary>
    /// Defines contants used in game
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Constant defining character in game
        /// </summary>
        public const char Miss = 'X', Hit = 'O', Ship = 'S';

        public const int GameboardSize = 10;

        /// <summary>
        /// Defines ship lengths
        /// </summary>
        public const int DestroyerLength = 2;
        public const int SubmarineLength = 3;
        public const int BattleshipLength = 4;
        public const int CarrierLength = 5;

    }
}
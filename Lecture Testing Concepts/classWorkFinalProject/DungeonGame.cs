using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classWorkFinalProject
{
    public class DungeonGame
    {
        GameGUI gameGUI = new GameGUI();
        GameLogic gameLogic = new GameLogic();

        public DungeonGame()
        {
            gameLogic.HeroesUpdate += gameGUI.HeroesUpdateHandler;
            gameLogic.EnemiesUpdate += gameGUI.EnemiesUpdateHandler;

            gameLogic.InitializeGame();
            Application.Run(gameGUI);
        }

    }
}

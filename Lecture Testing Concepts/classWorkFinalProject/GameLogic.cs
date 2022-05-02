using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classWorkFinalProject
{
    public class GameLogic
    {
        //events
        public event EventHandler<HeroesUpdateEventArgs>? HeroesUpdate;
        public event EventHandler<EnemiesUpdateEventArgs>? EnemiesUpdate;
        
        //lists
        List<Hero> heroList = new List<Hero>();
        List<Enemy> enemyEncounter = new List<Enemy>();
        List<Entity> turnOrder = new List<Entity>();
        
        //misc
        Random random = new Random();
        int roundCount = 0;
        int currentTurn = 0;

        public GameLogic()
        { 
            
        }

        public void InitializeGame()
        {
            AssembleHeroes();
            GenerateEncounter();
            SetTurnOrder();
            Update();
        }

        #region methods

        private void AssembleHeroes()
        {
            heroList.Add(new Warrior());
            heroList.Add(new Mage());
            heroList.Add(new Cleric());
            HeroesUpdated();
        }

        private void GenerateEncounter()
        { 
            enemyEncounter.Clear();
            int encounterSize = random.Next(1); //sets the number of encounters possible
            for (int i = 0; i <= encounterSize; i++)
            {
                int randomEnemy = random.Next(1); //set which encounters are possible
                switch (randomEnemy)
                {
                    case 0: 
                        enemyEncounter.Add(new Bandit());
                        break;
                    case 1:
                        enemyEncounter.Add(new Ogre());
                        break;
                    case 2:
                        enemyEncounter.Add(new Dragon());
                        break;
                    default:
                        throw new Exception("Enemy not in encounters list.");
                }
            }
            EnemiesUpdated();
        }

        private void SetTurnOrder()
        { 
            turnOrder.Clear();
            turnOrder.AddRange(heroList);
            turnOrder.AddRange(enemyEncounter);
            turnOrder = turnOrder.OrderByDescending(x => x.Speed).ToList();
        }
        #endregion

        #region Events Related

        //Heroes Related
        private void HeroesUpdated()
        { 
            HeroesUpdateEventArgs e = new HeroesUpdateEventArgs(heroList);
            OnHeroesUpdate(this, e);
        }

        protected virtual void OnHeroesUpdate(object? sender, HeroesUpdateEventArgs e)
        { 
            HeroesUpdate?.Invoke(sender, e);
        }

        //Enemies Related
        private void EnemiesUpdated()
        {
            EnemiesUpdateEventArgs e = new EnemiesUpdateEventArgs(enemyEncounter);
            OnEnemiesUpdate(this, e);
        }

        protected virtual void OnEnemiesUpdate(object? sender, EnemiesUpdateEventArgs e)
        {
            EnemiesUpdate?.Invoke(sender, e);
        }

        //Other
        private void Update()
        {
            UpdateEventArgs e = new UpdateEventArgs(turnOrder[currentTurn], currentTurn); 
        }

        #endregion
    }
}

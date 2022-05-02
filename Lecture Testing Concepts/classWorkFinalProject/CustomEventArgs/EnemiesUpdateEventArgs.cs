using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classWorkFinalProject
{
    public class EnemiesUpdateEventArgs : EventArgs
    {

        List<Enemy> enemyEncounter = new List<Enemy>();

        public EnemiesUpdateEventArgs(List<Enemy> list)
        { 
            enemyEncounter = list;
        }

        public List<Enemy> EnemyEncounter { get => enemyEncounter; }
    }
}

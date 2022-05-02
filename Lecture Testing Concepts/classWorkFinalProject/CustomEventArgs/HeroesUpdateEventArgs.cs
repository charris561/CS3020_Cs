using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classWorkFinalProject
{
    public class HeroesUpdateEventArgs : EventArgs
    {
        List<Hero> heroes = new List<Hero>();

        public HeroesUpdateEventArgs(List<Hero> heroes)
        { 
            this.heroes = heroes;
        }

        public List<Hero> Heroes { get => heroes; set => heroes = value; }
    }
}

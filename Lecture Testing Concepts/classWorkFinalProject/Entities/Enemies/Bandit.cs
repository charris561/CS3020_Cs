using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classWorkFinalProject
{
    public class Bandit : Enemy
    {
        public Bandit()
        {
            name = "Bandit";
            strength = 5;
            intelligence = 1;
            defense = 3;
            speed = 5;
            isDefending = false;
            hitPoints = 30;
            mySprite = Properties.Resources.Bandit;
        }
    }
}
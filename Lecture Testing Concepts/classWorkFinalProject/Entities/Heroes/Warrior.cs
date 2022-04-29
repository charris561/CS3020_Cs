using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classWorkFinalProject
{
    public class Warrior : Hero
    {
        public Warrior()
        {
            name = "Warrior";
            strength = 10;
            intelligence = 1;
            defense = 10;
            speed = 10;
            isDefending = false;
            hitPoints = 100;
            mySprite = Properties.Resources.Fighter;
        }
    }
}
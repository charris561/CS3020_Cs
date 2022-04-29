using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classWorkFinalProject
{
    public class Cleric : Hero
    {
        public Cleric()
        {
            name = "Cleric";
            strength = 5;
            intelligence = 10;
            defense = 10;
            speed = 5;
            isDefending = false;
            hitPoints = 100;
            mySprite = Properties.Resources.Cleric;
        }
    }
}
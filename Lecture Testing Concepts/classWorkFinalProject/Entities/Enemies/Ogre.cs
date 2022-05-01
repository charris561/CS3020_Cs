using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classWorkFinalProject
{
    public class Ogre : Enemy
    {
        public Ogre()
        {
            name = "Ogre"; 
            strength = 10;
            intelligence = 1;
            defense = 10;
            speed = 5;
            isDefending = false;
            hitPoints = 75;
            mySprite = Properties.Resources.Ogre;
        }
    }
}
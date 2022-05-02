using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classWorkFinalProject
{
    public class Mage : Hero
    {
        public Mage()
        {
            name = "Mage";
            strength = 3;
            intelligence = 10;
            defense = 5;
            speed = 3;
            isDefending = false;
            hitPoints = 50;
            mySprite = Properties.Resources.Mage;
        }
    }
}
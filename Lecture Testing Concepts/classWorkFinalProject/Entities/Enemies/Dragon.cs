using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classWorkFinalProject
{
    public class Dragon : Enemy
    {
        public Dragon()
        {
            name = "Dragon";
            strength = 10;
            intelligence = 7;
            defense = 10;
            speed = 2;
            isDefending = false;
            hitPoints = 150;
            mySprite = Properties.Resources.Dragon;
        }
    }
}
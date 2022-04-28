using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classWorkFinalProject
{
    public class Entity
    {
        protected string name;
        protected int strength;
        protected int intelligence;
        protected int defense;
        protected int speed;
        protected bool isDefending;
        protected int hitPoints;
        protected System.Drawing.Bitmap mySprite;

        public void Attack()
        {
            throw new System.NotImplementedException();
        }

        public void Defend()
        {
            throw new System.NotImplementedException();
        }
    }
}
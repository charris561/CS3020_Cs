using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classWorkFinalProject
{
    public class Entity
    {
        #region fields
        protected string? name;
        protected int strength;
        protected int intelligence;
        protected int defense;
        protected int speed;
        protected bool isDefending;
        protected int hitPoints;
        protected System.Drawing.Bitmap? mySprite;
        #endregion

        #region properties
        public string? Name { get => name; }
        public int Strength { get => strength; }
        public int Intelligence { get => intelligence; }
        public int Defense { get => defense; }
        public int Speed { get => speed; }
        public bool IsDefending { get => isDefending; set => isDefending = value; }
        public int HitPoints { get => hitPoints; set => hitPoints = value; }
        public Bitmap? MySprite { get => mySprite; } // image for fix?(!)
        #endregion

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
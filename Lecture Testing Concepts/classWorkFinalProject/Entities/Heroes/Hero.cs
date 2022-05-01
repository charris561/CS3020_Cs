﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classWorkFinalProject
{
    public class Hero : Entity
    {

        protected string specialName = "Spin Move";

        /// <summary>
        /// The special move for each hero
        /// </summary>
        public virtual void Special()
        {
            throw new System.NotImplementedException();
        }
    }
}
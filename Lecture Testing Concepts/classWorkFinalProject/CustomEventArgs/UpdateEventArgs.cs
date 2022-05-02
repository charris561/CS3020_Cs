using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classWorkFinalProject
{
    /// <summary>
    /// This event data will contain data for updating aspects of the game.
    /// </summary>
    internal class UpdateEventArgs : EventArgs
    {
        string? updateMessage;
        int currentTurn;
        Entity entity;

        public UpdateEventArgs(Entity entity, int turn)
        { 
            this.Entity = entity;
            CurrentTurn = turn;
        }

        public string? UpdateMessage { get => updateMessage; set => updateMessage = value; }
        public int CurrentTurn { get => currentTurn; set => currentTurn = value; }
        public Entity Entity { get => entity; set => entity = value; }

    }
}

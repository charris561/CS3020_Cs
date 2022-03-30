using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMyDude
{
    public class KitchenEventArgs : EventArgs
    {

        List<string> orderItems = new List<string>();

        public KitchenEventArgs()
        {
        }

        public KitchenEventArgs(List<string> orderItems)
        {
            this.OrderItems = orderItems;
        }

        public List<string> OrderItems { get => orderItems; set => orderItems = value; }
    }
}
